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

namespace QuizzAndTest
{
    public partial class Jeu : Form
    {

        int reponseQuestion = 0;
        partie partie;
        int dureeTQuestion = 0;

  



        private void Init()
        {
            InitializeComponent();
            List<question> ListeQuestions = new List<question>();
            ListeQuestions.Add(new question("Quelle est la capitale de la France ?", 1, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new question("Quelle est la capitale de l'Espagne ?", 4, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new question("Quelle est la capitale de l'Allemagne ?", 3, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new question("Quelle est la capitale de l'Italie ?", 5, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new question("Quelle est la capitale de l'Angleterre ?", 2, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new question("Quelle est la capitale de la Belgique ?", 1, 1, "Bruxelles", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new question("Quelle est la capitale de la Suisse ?", 2, 1, "Bruxelles", "Berne", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new question("Quelle est la capitale du Luxembourg ?", 3, 1, "Bruxelles", "Berne", "Luxembourg", "Madrid", "Rome"));
            ListeQuestions.Add(new question("Quelle est la capitale du Portugal ?", 4, 1, "Bruxelles", "Berne", "Luxembourg", "Lisbonne", "Rome"));
            ListeQuestions.Add(new question("Quelle est la capitale de l'Autriche ?", 5, 1, "Bruxelles", "Berne", "Luxembourg", "Lisbonne", "Vienne"));
            partie = new partie(ListeQuestions);
            partie.changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, this, gd_reponse, pb_question);
        }
        public Jeu ()
        {
            Init();
        }
        


        public Jeu(string nomJ , string PrenomJ, string DifficultePartie)    
        {
            Init();
            txt_joueur.Text = nomJ + "" + PrenomJ;
            txt_diff.Text = DifficultePartie;

        }


        public void Timer_tick(object sender, EventArgs e, TextBox txt_timer)
        {
            partie.TimerPartie++;
            txt_timer.Text = partie.TimerPartie.ToString() + "sec";

        }
        public void gestionTimer(TextBox txt_timer)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => Timer_tick(sender, e, txt_timer);

            timer.Start();
        }


        public void ArreterTimer(TextBox txt_timer , Timer timer)
        {
                timer.Stop();
                txt_timer.Text = "Temps total : " + partie.TimerPartie + " sec";

        }

        public void ReinitialiserTimer(TextBox txt_timer, Timer timer)
        {
            timer.Stop();
            partie.TimerPartie = 0;
        }

        ProgressBar progressbar = new ProgressBar();
        public void Progressbar_tick(object sender, EventArgs e, ProgressBar progressbar)
        {
            Timer_tick(sender, e, txt_timer);
            progressbar.Increment(1);
            if (progressbar.Value == 100) {
                progressbar.Value = 0;
            }

        }
























        private void btn_valider_Click(object sender, EventArgs e)
        {
            partie.validerReponse(reponseQuestion, pb_question);
            partie.numQuestion++;
            partie.changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, this, gd_reponse, pb_question);
            lbl_numero.Text = (partie.numQuestion + 1).ToString();
            reponseQuestion = 0;
            progressbar.Value = 0;
            dureeTQuestion = 0;




        }

        private void Jeu_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
