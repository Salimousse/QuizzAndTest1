using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO.Ports;
using System.Linq;
using System.Net.Configuration;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizzAndTest.Model;

namespace QuizzAndTest
{
    public class partie
    {
        public int score;
        public int difficulte;
        public int nbquestion;
        public int numBonnereponse;
        public int numQuestion;
        public List<question> ListeQuestions;
        public int reponseValidQuestion;

        public partie(List<question> questions)
        {
            this.score = 0;
            this.difficulte = 0;
            this.nbquestion = 0;
            this.ListeQuestions = questions;
            this.nbquestion = questions.Count();
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

        private void calculerScore(bool BonneReponse)
        {
            if (BonneReponse == true)
            {
                score = score++;
            }
            else
            {
                score = score--;
            }
        }
        public void validerReponse(int reponse, PictureBox pbimage)
        {
            bool bonneReponse = reponse == reponseValidQuestion;
            calculerScore(bonneReponse);
            changerImg(pbimage, bonneReponse, false);
            

        }
        public void changerQuestion(TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage)
        {
            if (numQuestion < nbquestion)   // On teste si il reste des questions )
            {
                aleatoireReponse(txt_affichage, gd_reponse);
                ckb_reponse1.Checked = false;
                ckb_reponse2.Checked = false;
                ckb_reponse3.Checked = false;
                ckb_reponse4.Checked = false;
                ckb_reponse5.Checked = false;


                // On décoche les 5 checkbox

            }
            else
            {
                //appel de la méthode de fin de partie qui sera réalisé plus tard
            }

        }

        private void aleatoireReponse(TextBox txt_affichage, GroupBox gd_reponse)
        {
            int bonneReponse = ListeQuestions[numQuestion].reponse;
            txt_affichage.Text = ListeQuestions[numQuestion].enonce;                    //Afficher l’énoncé de la question

            List<int> reponseAleatoire = new List<int>() { 1, 2, 3, 4, 5 };
            Random rnd = new Random();

            for (int i = 1; i <= 5; i++)
            {
                int randIndex = rnd.Next(reponseAleatoire.Count);
                int random = reponseAleatoire[randIndex];
                reponseAleatoire.Remove(random);
                string reponse = "";
                switch (random)
                {
                    case 1:
                        reponse = ListeQuestions[numQuestion].proposition1;
                        break;
                    case 2:
                        reponse = ListeQuestions[numQuestion].proposition2;
                        break;
                    case 3:
                        reponse = ListeQuestions[numQuestion].proposition3;
                        break;
                    case 4:
                        reponse = ListeQuestions[numQuestion].proposition4;
                        break;
                    case 5:
                        reponse = ListeQuestions[numQuestion].proposition5;
                        break;





                }
                getCheckBox(i, gd_reponse).Text = reponse;
                if (bonneReponse == random)

                    reponseValidQuestion = i;
            }


        }
            
        
           

            private CheckBox getCheckBox(int indice, GroupBox gd_reponse)
        {
            foreach (Control c in gd_reponse.Controls) {
                if (c.GetType() == typeof(CheckBox) && c.Name == "ckb_reponse" + indice.ToString())
                {
                    return (CheckBox)c;
                }
            }
            return null;
        }

        public void findepartie(DialogResult msg, PictureBox PbImage,Form FormulaireJeuActif)
        {
            msg = MessageBox.Show("Votre score est de " + score + "./r/n Voulez-vous rejouer ?", "Fin de partie", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (msg == DialogResult.Yes)
            {
                score = 0;
                changerImg(PbImage, false, true);



            }
            else
            {
                Form1 Accueil = new Form1();
                Accueil.Show();
                FormulaireJeuActif.Hide();


            }
        }










            }
    }

