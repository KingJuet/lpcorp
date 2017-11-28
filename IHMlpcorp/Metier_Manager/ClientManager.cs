using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectToSQLServer;
using lpcorp_metier;
namespace Metier_Manager
{
    public class ClientManager
    {
        private CSV file;
        private List<Client> lesClients;
        private bool isTreat;
        public ClientManager(string path)
        {
            this.isTreat = false;
            this.file = new CSV(path);
        }
        private bool CreateClients()
        {
            this.file.ExtractData();
            for (int i = 0; i < file.GetData().Count; i++)
            {
                this.lesClients.Add(new Client(file.GetData()[i][0], file.GetData()[i][1], file.GetData()[i][2], file.GetData()[i][3], file.GetData()[i][4], file.GetData()[i][5], file.GetData()[i][6], file.GetData()[i][7], file.GetData()[i][8], file.GetData()[i][9])); 
            }
            return true;
        }
        public bool ToDataBase()
        {

            return true;
        }
        

        
    }
}
