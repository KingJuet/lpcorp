using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier_Manager;
namespace lpcorp_IHM
{
    public partial class LPCORP_Frm : Form
    {
        public LPCORP_Frm()
        {
            InitializeComponent();
        }

        private void btn_Transferer_Click(object sender, EventArgs e)
        {
            ClientManager cm = new ClientManager("F:\\Julien Rull\\Cours\\PPE\\Negomat_Client.csv");
            cm.PushToDataBase();

        }
    }
}
