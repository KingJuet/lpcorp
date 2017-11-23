using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lpcorp_metier
{
    public class Client
    {
        private string code;
        private string raisonSociale;
        private string adresse;
        private string cp;
        private string ville;
        private string tel;
        private string fax;
        private string email;
        private string actif;
        private string reglement;

        public Client(string unCode, string uneRaison, string uneAdresse, string unCp, string uneVille, string unTel, string unFax, string unEmail, string estActif, string unReglement)
        {
            this.code = unCode;
            this.raisonSociale = uneRaison;
            this.adresse = uneAdresse;
            this.cp = unCp;
            this.ville = uneVille;
            this.cp = unCp;
            this.ville = uneVille;
            this.tel = unTel;
            this.fax = unFax;
            this.email = unEmail;
            this.actif = estActif;
            this.reglement = unReglement;
        }



    }
}
