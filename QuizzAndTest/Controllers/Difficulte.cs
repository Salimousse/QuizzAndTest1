using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using QuizzAndTest.Model;

namespace QuizzAndTest.Controllers
{
   public class Difficulte
    {
        public DataTable GetListeDifficulte()
        {
            DataTable dt = new DataTable();
            connectionBDD conn = new connectionBDD();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDDIFFICULTE, LABELDIFFICULTE FROM DIFFICULTE", conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            conn.MySqlCo.Close();
            conn.MySqlCo = null;
            return dt;
        }

    }
}