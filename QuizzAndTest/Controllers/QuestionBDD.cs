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
            conn.MySqlCo.Close();
            conn.MySqlCo = null;
            return dt;


        }
        public DataTable GetListeQuestionRecherche(string rqtSql , int diff)
        {
            dt = new DataTable();
            try
            {
                Connection conn = new Connection();
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.connection))
                {
                    conn.connection.Open();
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
            return dt;


        }





    }


}

