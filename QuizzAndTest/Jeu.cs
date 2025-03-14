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
            List<Question> ListeQuestions = new List<Question>();
            ListeQuestions.Add(new Question("Quelle est la capitale de la France ?", 1, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Espagne ?", 4, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Allemagne ?", 3, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Italie ?", 5, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Angleterre ?", 2, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de la Belgique ?", 1, 1, "Bruxelles", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de la Suisse ?", 2, 1, "Bruxelles", "Berne", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale du Luxembourg ?", 3, 1, "Bruxelles", "Berne", "Luxembourg", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale du Portugal ?", 4, 1, "Bruxelles", "Berne", "Luxembourg", "Lisbonne", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Autriche ?", 5, 1, "Bruxelles", "Berne", "Luxembourg", "Lisbonne", "Vienne"));
            partie = new Partie(ListeQuestions);
            partie.changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, this, gd_reponse, pb_question, null);
            partie.gestionTimer(txt_timer, pgb_tpsQuestion, txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, this,gd_reponse,pb_question,lbl_numero,null);
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
    }
}
