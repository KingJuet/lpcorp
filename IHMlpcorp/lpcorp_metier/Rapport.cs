using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lpcorp_metier
{
    public class Rapport
    {
        private List<List<string>> lesData;
        private CSV file;
        private int nbLignesTraitees;
        private int nbLignesInserees;
        private int nbDoublon;
        private int nbInvalidEmail;
        private string errorMessages;


        public Rapport(string pathFile)
        {
            this.file = new CSV(pathFile);
            this.nbLignesTraitees = 0;
            this.nbLignesInserees = 0;
            this.nbDoublon = 0;
            this.nbInvalidEmail = 0;
            this.errorMessages = "";
    }

        public List<List<string>> GetRapport()
        {
            this.lesData = file.Formater(this);
            return this.lesData;
        }

        public override string ToString()
        {
            return "Rapport : \r\n"
                    + "Lignes Traitées : " + this.nbLignesTraitees + "\r\n"
                    + "Lignes Insérées : " + this.nbLignesInserees + "\r\n"
                    + "Doublons : " + this.nbDoublon + "\r\n"
                    + "Emails invalides : " + this.nbInvalidEmail + "\r\n"
                    + "\r\n"
                    + this.errorMessages + "\r\n";
        }
        public int NbLignesTraitees
        {
            get
            {
                return nbLignesTraitees;
            }

            set
            {
                nbLignesTraitees = value;
            }
        }

        public int NbLignesInserees
        {
            get
            {
                return nbLignesInserees;
            }

            set
            {
                nbLignesInserees = value;
            }
        }

        public int NbDoublon
        {
            get
            {
                return nbDoublon;
            }

            set
            {
                nbDoublon = value;
            }
        }

        public int NbInvalidEmail
        {
            get
            {
                return nbInvalidEmail;
            }

            set
            {
                nbInvalidEmail = value;
            }
        }

        public string ErrorMessages
        {
            get
            {
                return errorMessages;
            }

            set
            {
                errorMessages = value;
            }
        }
    }
}
