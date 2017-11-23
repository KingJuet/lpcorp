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
        private string filePath;
        private CSV file;
        private List<Client> lesClients;
        private bool isTreat;
        public ClientManager(string path)
        {
            this.isTreat = false;
            this.filePath = path;
            this.file = new CSV(this.filePath);
        }

        public void 

        
    }
}
