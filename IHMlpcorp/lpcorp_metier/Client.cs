using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lpcorp_metier
{
    public class Client
    {
        private int id;
        private string raisonSociale;
        private string adresse;
        private string cp;
        private string ville;
        private string tel;
        private string fax;
        private string email;
        private string actif;
        private string reglement;

        public Client(int unId, string uneRaison, string uneAdresse, string unCp, string uneVille, string unTel, string unFax, string unEmail, string estActif, string unReglement)
        {
            this.id = unId;
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

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string RaisonSociale
        {
            get
            {
                return raisonSociale;
            }

            set
            {
                raisonSociale = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string Cp
        {
            get
            {
                return cp;
            }

            set
            {
                cp = value;
            }
        }

        public string Ville
        {
            get
            {
                return ville;
            }

            set
            {
                ville = value;
            }
        }

        public string Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
            }
        }

        public string Fax
        {
            get
            {
                return fax;
            }

            set
            {
                fax = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Actif
        {
            get
            {
                return actif;
            }

            set
            {
                actif = value;
            }
        }

        public string Reglement
        {
            get
            {
                return reglement;
            }

            set
            {
                reglement = value;
            }
        }
    }
}
