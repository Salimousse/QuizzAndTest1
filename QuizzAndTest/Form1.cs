using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzAndTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            difficulte.Items.Add("Facile");
            difficulte.Items.Add("Moyen");
            difficulte.Items.Add("Difficile");
            difficulte.Items.Add("Enfer");
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            string result = "Bonjour";
            result += " ";
            result += txt_nom.Text;
            result += " ";
            result += txt_prenom.Text;
            txt_afficher.Text = result ; // commentaire
            if(txt_nom.Text == "")
            {
                MessageBox.Show("Aucun nom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if(txt_prenom.Text == "")
            {
                MessageBox.Show("Aucun prénom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(txt_prenom.Text == "" && txt_prenom.Text == "")
            {
                txt_afficher.Text = "Les deux champs sont vides ";
            }
            txt_afficher.Text = "La valeur selectionné est " + difficulte.SelectedItem;
            



        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void difficulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (difficulte.SelectedItem == "Enfer")
            {
                this.BackColor = Color.Red;
                lbl_rep.Font = new Font(lbl_rep.Font, FontStyle.Bold);
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Bold);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Bold);
                lbl_difficulte.Font = new Font(lbl_difficulte.Font, FontStyle.Bold);

            }
            else
            {
                this.BackColor = Color.FromArgb(153, 180, 209);
                lbl_rep.Font = new Font(lbl_rep.Font, FontStyle.Regular);
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Regular);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Regular);
                lbl_difficulte.Font = new Font(lbl_difficulte.Font, FontStyle.Regular);
            }

        }
    }
}
