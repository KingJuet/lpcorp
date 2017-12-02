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



        public Rapport(string pathFile)
        {
            this.file = new CSV(pathFile);
        }

        public List<List<string>> GetRapport()
        {
            this.lesData = file.Formater(this);
            return this.lesData;
        }

        public override string ToString()
        {
            return "Rapport : \n" 
                    + "Lignes Traitées : " + this.nbLignesTraitees + "\n"
                    + "Lignes Insérées : " + this.nbLignesInserees + "\n"
                    + "Doublons : " + this.nbDoublon + "\n"
                    + "Emails invalides : " + this.nbInvalidEmail + "\n";
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
    }
}
