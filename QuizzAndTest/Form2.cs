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
            //Cacher les colonnes qui ne servent à rien pour l’utilisateur
            dgv_questions.Columns["IDQUESTION"].Visible = false;
            //Gérer la largeur des colonnes
            dgv_questions.Columns["ENONCEQUESTION"].Width = 190;
            //Attention il faut mettre le nom des alias à la place du nom des colonnes en cas d’utilisation d’alias dans la requête SQL.



        }

        private void pnl_bdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
