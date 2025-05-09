using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizzAndTest.Model;
using MySqlConnector;


namespace QuizzAndTest.Controllers
{
    public class QuestionBDD
    {
        public DataTable GetListeQuestion()
        {
            DataTable dt = new DataTable();
            connectionBDD conn = new connectionBDD();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDQUESTION , ENONCEQUESTION as question , D.IDDIFFICULTE , LABELDIFFICULTE as difficulte  FROM QUESTION inner join DIFFICULTE D on QUESTION.IDDIFFICULTE = D.IDDIFFICULTE group by IDQUESTION;", conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            finally
            {
                conn.MySqlCo.Close();
                conn.MySqlCo = null;
            }
            return dt;
        }

        public DataTable GetListeQuestionRecherche(string rqtSql, string rechercheMot, int difficulte)
        {
            DataTable dt = new DataTable();
            connectionBDD conn = new connectionBDD();
            string rqlsql;
            if (difficulte > 0)
            {
                rqtSql = "SELECT IDQUESTION, ENONCEQUESTION as question, D.IDDIFFICULTE, LABELDIFFICULTE as difficulte " +
                         "FROM QUESTION inner join DIFFICULTE D on QUESTION.IDDIFFICULTE = D.IDDIFFICULTE " +
                         "WHERE ENONCEQUESTION LIKE @rechercheMot AND D.IDDIFFICULTE = @difficulte " +
                         "GROUP BY IDQUESTION;";
            }
            else
            {
                rqtSql = "SELECT IDQUESTION, ENONCEQUESTION as question, D.IDDIFFICULTE, LABELDIFFICULTE as difficulte " +
                         "FROM QUESTION inner join DIFFICULTE D on QUESTION.IDDIFFICULTE = D.IDDIFFICULTE " +
                         "WHERE ENONCEQUESTION LIKE @rechercheMot " +
                         "GROUP BY IDQUESTION;";
            }

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    cmd.Parameters.AddWithValue("@rechercheMot", "%" + rechercheMot + "%");
                    cmd.Parameters.AddWithValue("@difficulte", difficulte);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            finally
            {
                conn.MySqlCo.Close();
                conn.MySqlCo = null;
            }
            return dt;
        }

        public DataTable GetListeQuestionsParDifficulte(int difficulteId)
        {
            DataTable dt = new DataTable();
            connectionBDD conn = new connectionBDD();

            try
            {
                // Requête SQL pour récupérer les questions en fonction de la difficulté
                string query = "SELECT * FROM QUESTION WHERE IDDIFFICULTE = @difficulteId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn.MySqlCo))
                {
                    // Ajout du paramètre pour éviter les injections SQL
                    cmd.Parameters.AddWithValue("@difficulteId", difficulteId);

                    conn.MySqlCo.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                // Gestion des erreurs
                MessageBox.Show($"Erreur lors de la récupération des questions : {e.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Assurez-vous de fermer la connexion
                if (conn.MySqlCo != null && conn.MySqlCo.State == ConnectionState.Open)
                {
                    conn.MySqlCo.Close();
                }
            }

            return dt;
        }
    }
}


    

