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
        private bool Formatage()
        {
            this.file.ExtractData();
            for (int i = 0; i < file.GetData().Count; i++)
            {
                for (int j = 0; j < file.GetData()[i].Count; j++)
                {
                    Console.Write(" ");
                    Console.Write(file.GetData()[i][j]);
                }
                Console.WriteLine("");
            }
            return true;
        }
        public bool ToDataBase()
        {
            this.Formatage();
            return true;
        }
        

        
    }
}
