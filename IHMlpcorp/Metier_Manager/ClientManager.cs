using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RH_Donnees;
using lpcorp_metier;
namespace Metier_Manager
{
    public class ClientManager
    {
        private Rapport rapport;
        private List<Client> lesClients;
        private DAOClient pusher;
        public ClientManager(string path, DAOClient uneConnexion)
        {
            this.rapport = new Rapport(path);
            this.lesClients = new List<Client>();
            this.pusher = uneConnexion;
        }
        private bool CreateClients()
        {
            
            List<List<string>> data = this.rapport.GetRapport();
            for (int i = 0; i < data.Count; i++)
            {
                    
                    this.lesClients.Add(new Client(i + 6, data[i][1], data[i][2], data[i][3], data[i][4],
                                                     data[i][5], data[i][6], data[i][7], data[i][8],
                                                     data[i][9])); 
            }
            return true;
        }
        public bool PushToDataBase()
        {
            this.CreateClients();
            this.pusher.AjouterDesClients(this.lesClients);
            return true;
        }

        public string GetRapport()
        {
            return this.rapport.ToString();
        }
        

        
    }
}
