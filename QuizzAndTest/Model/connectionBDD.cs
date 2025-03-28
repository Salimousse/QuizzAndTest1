using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace QuizzAndTest.Model
{
    internal class connectionBDD
    {
        private MySqlConnection mySqlCo;
        private string serveurBDD;
        private string nomBDD;
        private string loginBDD;
        private string mdpBDD;


        private void InitConnection()
        {
            mySqlCo = new MySqlConnection("Server=" + serveurBDD + ";Database=" + nomBDD + ";User ID=" + loginBDD + ";Password=" + mdpBDD);
        }

        public connectionBDD()
        {
            serveurBDD = "192.168.10.16";
            nomBDD = "settouti_salim_bdd_slam2_tp3";
            loginBDD = "settouti_salim";
            mdpBDD = "CEjsNE26";
            InitConnection();
        }

        public MySqlConnection MySqlCo { get { return mySqlCo; } set { mySqlCo = value; } }
    }
}



