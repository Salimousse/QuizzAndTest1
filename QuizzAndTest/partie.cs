using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzAndTest
{
    public class partie
    {
        public int score;
        public int difficulte;
        public int nbquestion;
        public int numBonnereponse;
        public int numQuestion;
        public List <question> ListeQuestions = new List<Question> ();

        public partie(List<int> questions)
        {
            this.score = 0;
            this.difficulte = 0;
            this.nbquestion = 0;
            this.questions = questions;
            questions.Count();

        }

        private void changerImg(PictureBox pbimage, bool BonneReponse, bool raz)
        {
            if (!raz)
            {
                if (BonneReponse)
                {
                    pbimage.Image = Properties.Resources.vrai;
                }
                else
                {
                    pbimage.Image = Properties.Resources.faux;
                }
            }
        }

        private void calculerScore(bool reponse)
        {
            if (reponse == true)
            {
                score = score + 1;
            }
            else
            {
                score = score - 1;
            }
        }
        public void validerReponse(int reponse, PictureBox pbimage, int reponseValidQuestion)
        {
            if (reponse == reponseValidQuestion)
            {
                calculerScore(true);
                changerImg(pbimage, true, false);
            }
        }

        public void changerQuestion(TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox pbimage)
        {
            if()
            {
                aleatoireReponse(txt_affichage, gd_reponse);

            }
            else
            {

            }

        }
        private void aleatoireReponse(TextBox txt_affichage , GroupBox gd_reponse)
        {



        }
    }
}

