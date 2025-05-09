using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizzAndTest.Controllers;
using QuizzAndTest.Model;

namespace QuizzAndTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chargerDifficultes();
           


        }
        private void chargerDifficultes()
        {
            List<Question> ListeQuestions = new List<Question>();
            Difficulte difficulte = new Difficulte();
            DataTable dt = difficulte.GetListeDifficulte();

            foreach (DataRow row in dt.Rows)
            {
               cb_difficulte.Items.Add(row["LABELDIFFICULTE"].ToString());

            }
        }



        private void btn_valider_Click(object sender, EventArgs e)
        {
            


            if (txt_nom.Text == "")
            {
                MessageBox.Show("Aucun nom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if(txt_prenom.Text == "")
            {
                MessageBox.Show("Aucun prénom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            (System.Windows.Forms.Application.OpenForms["Menu"] as Menu).openChildForm(new Jeu(txt_nom.Text, txt_prenom.Text, cb_difficulte.SelectedItem.ToString()));
            this.Hide();
       


        }

        private void difficulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_difficulte.SelectedItem == "Enfer")
            {
                this.BackColor = Color.Red;
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Bold);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Bold);
                lbl_difficulte.Font = new Font(lbl_difficulte.Font, FontStyle.Bold);

            }
            else
            {
                this.BackColor = Color.FromArgb(153, 180, 209);
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Regular);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Regular);
                lbl_difficulte.Font = new Font(lbl_difficulte.Font, FontStyle.Regular);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
