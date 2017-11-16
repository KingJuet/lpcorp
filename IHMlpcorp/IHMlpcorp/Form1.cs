using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectToSQLServer;

namespace IHMlpcorp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonParcourir1_Click(object sender, EventArgs e)
        {
            string sPath;
            foreach (string sFileName in System.IO.Directory.GetFiles(sPath))
            {
                if (System.IO.Path.GetExtension(sFileName) == ".txt")
                {
                    //Do some treatments
                }
            }
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            Connection.TestConnection();
        }
    }
}
