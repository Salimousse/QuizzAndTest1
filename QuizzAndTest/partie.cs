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
        List<int> questions = new List<int>();

        public partie(List<int> question)
        {
            score = 0;
            difficulte = 0;
            nbquestion = 0;
            this.questions = question;
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
    }
}
