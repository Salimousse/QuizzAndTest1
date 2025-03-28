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

namespace QuizzAndTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DataView dv = new DataView();

            QuestionBDD dt_listeQuestions = new QuestionBDD();
            dv = new DataView(dt_listeQuestions.GetListeQuestion());
            dgv_questions.DataSource = dv;
            Difficulte dt_ListeDifficulte = new Difficulte();
            DataTable dt = dt_ListeDifficulte.GetListeDifficulte();
            DataRow workRow = dt.NewRow();
            workRow[0] = -1;
            workRow[1] = "";
            dt.Rows.InsertAt(workRow, 0);

            cb_difficulte.DataSource = dt;
            cb_difficulte.DisplayMember = "LABELDIFFICULTE";
            cb_difficulte.ValueMember = "IDDIFFICULTE";

            //Gérer les noms des colonnes
            dgv_questions.Columns["question"].HeaderText = "Question";
            dgv_questions.Columns["difficulte"].HeaderText = "Difficulté";

            //Cacher les colonnes qui ne servent à rien pour l’utilisateur
            dgv_questions.Columns["IDQUESTION"].Visible = false;
            dgv_questions.Columns["IDDIFFICULTE"].Visible = false;
            //Gérer la largeur des colonnes
            dgv_questions.Columns["question"].Width = 190;
            dgv_questions.Columns["difficulte"].Width = 190;
            //Attention il faut mettre le nom des alias à la place du nom des colonnes en cas d’utilisation d’alias dans la requête SQL.
        }

        private void pnl_bdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
