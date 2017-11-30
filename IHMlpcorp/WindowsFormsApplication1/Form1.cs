using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lpcorp_IHM
{
    public partial class LPCORP_Frm : Form
    {
        string fileLink;
        public LPCORP_Frm()
        {
            InitializeComponent();
        }

        private void btn_Parcourir_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "xls";
            openFile.Filter = "Fichier MapInfoFormat (*.xls)|*.xls";
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
                fileLink = openFile.FileName;
            txt_parcourir.Text = fileLink;
            }
        }
    }
