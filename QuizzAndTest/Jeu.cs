using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizzAndTest.Controllers;
using QuizzAndTest.Model;
using static System.Net.Mime.MediaTypeNames;

namespace QuizzAndTest
{
    public partial class Jeu : Form
    {

        int reponseQuestion = 0;
        Partie partie;
        int dureeTQuestion = 0;





        private void Init()
        {
            InitializeComponent();
            List<Question> ListeQuestions = chargerQuestionsBDD(txt_diff.Text);

            partie = new Partie(ListeQuestions);
            partie.changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, this, gd_reponse, pb_question, null);
            partie.gestionTimer(txt_timer, pgb_tpsQuestion, txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, this,gd_reponse,pb_question,lbl_numero,null);
            
        }
        private List<Question> chargerQuestionsBDD(string difficulte)
        {
            List<Question> ListeQuestions = new List<Question>();

            try
            {
                // Instanciez QuestionBDD pour accéder aux questions
                QuestionBDD questionBDD = new QuestionBDD();

                // Récupérez l'ID de la difficulté
                int difficulteId = obtenirIdDifficulte(difficulte);

                // Récupérez les questions depuis la base de données
                DataTable dt = questionBDD.GetListeQuestionsParDifficulte(difficulteId);

                // Parcourez les résultats et créez des objets Question
                foreach (DataRow row in dt.Rows)
                {
                    ListeQuestions.Add(new Question(
                        row["ENONCEQUESTION"].ToString(),          // Énoncé de la question
                        Convert.ToInt32(row["BONREPQUESTION"]),      // Indice de la bonne réponse
                        difficulteId,                              // Difficulté
                        row["REPONSE1QUESTION"].ToString(),            // Proposition 1
                        row["REPONSE2QUESTION"].ToString(),            // Proposition 2
                        row["REPONSE3QUESTION"].ToString(),            // Proposition 3
                        row["REPONSE4QUESTION"].ToString(),            // Proposition 4
                        row["REPONSE5QUESTION"].ToString()             // Proposition 5
                    ));
                }

                // Vérifiez si des questions ont été récupérées
                if (ListeQuestions.Count == 0)
                {
                    MessageBox.Show("Aucune question trouvée pour cette difficulté.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des questions : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ListeQuestions;
        }

        private int obtenirIdDifficulte(string difficulte)
        {
            int difficulteId = 0; // Valeur par défaut si la difficulté n'est pas trouvée
            try
            {
                // Instanciez la classe Difficulte pour accéder à la base de données
                Difficulte difficulteController = new Difficulte();

                // Récupérez la liste des difficultés depuis la base de données
                DataTable dt = difficulteController.GetListeDifficulte();

                // Parcourez les lignes pour trouver l'ID correspondant au label
                foreach (DataRow row in dt.Rows)
                {
                    if (row["LABELDIFFICULTE"].ToString().Equals(difficulte, StringComparison.OrdinalIgnoreCase))
                    {
                        difficulteId = Convert.ToInt32(row["IDDIFFICULTE"]);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération de l'ID de la difficulté : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return difficulteId;
        }



        public Jeu ()
        {
            Init();
        }
        


        public Jeu(string nomJ , string PrenomJ, string DifficultePartie)    
        {
            Init();
            txt_joueur.Text =      nomJ + " " + PrenomJ;
            txt_diff.Text = DifficultePartie;

        }


        private void btn_valider_Click(object sender, EventArgs e)
        {
            partie.validerReponse(reponseQuestion, pb_question);
            partie.numeroQuestion++;
            partie.changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, this, gd_reponse, pb_question, null);
            lbl_numero.Text = (partie.numeroQuestion + 1).ToString();

            reponseQuestion = 0;
            pgb_tpsQuestion.Value = 0;
            dureeTQuestion = 0;
            partie.Timer_Tick(sender , e , txt_timer, pgb_tpsQuestion, txt_affichage, ckb_reponse1 , ckb_reponse2 , ckb_reponse3, ckb_reponse4,ckb_reponse5,this,gd_reponse,pb_question,lbl_numero,null);





        }

        private void Jeu_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ckb_reponse1_Click(object sender, EventArgs e)
        {
            foreach (var box in gd_reponse.Controls.OfType<CheckBox>())
            {
                if (box.Checked)
                {
                    box.Checked = false;
                }
            } 
            ((CheckBox)sender).Checked = true;
            reponseQuestion = Convert.ToInt32(((CheckBox)sender).Name.Substring(((CheckBox)sender).Name.Length - 1, 1));
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
