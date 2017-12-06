using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Mail;
namespace lpcorp_metier
{
    /// <summary>
    /// Classe : Traite les fichiers .csv
    /// </summary>
    public class CSV
    {
        private string filePath;  // Chemin du fichier
        private StreamReader reader; // Pour lire les fichiers
        private Regex myRegex; // Pour effectuer des expressions régulières
      

        public CSV(string path)
        {
            this.filePath = path;
            this.reader = new StreamReader(path);
            myRegex = new Regex("([a-z]+|[A-Z]+)");
        }


        public string GetFilePath()
        {
            return this.filePath;
        }


        /// <summary>
        /// Formate , construit le rapport en paramètre et retourne les données du csv
        /// </summary>
        /// <param name="rap">Instance d'un rapport sur lequel le formatage va écrire</param>
        /// <returns></returns>
        public List<List<string>> Formater(Rapport rap)
        {


           
            
            List<List<string>> lesData = new List<List<string>>(); // Liste des données formaté retourné à la fin du programme
            List<string> laLigne = new List<string>(); // Ligne tempon, permet de vérifié si une ligne est valide sinon on ne l'insère pas dans lesData
            bool inserer = false; // Booléen qui détermine si une ligne peut-etres inséré
            int ligne = 0; // Numero de la ligne à inséré
            if (this.filePath != "null") // Si un chemin à bien été spécifié
            {
                while (!reader.EndOfStream) // Tant que la lecture n'est pas arrivé à la fin du fichier csv
                {

                    string line = reader.ReadLine(); // On lit la ligne sous forme de format string
                    string[] values = line.Split(';'); // On la découpe dans un tableau avec des ";" en critère de séparation pour le découpage

                    int actualLingne = rap.NbLignesTraitees + 1; // Numéro de la ligne actuellement à traité
                    rap.ErrorMessages += "------------------LIGNE " + actualLingne.ToString() + "------------------\r\n"; 
                        for (int i = 0; i < values.Length; i++) // pour tout les élément de la ligne à traité
                        {
                       //Supression des xxxxxxx pour toute collone traité
                        values[i].ToLower();
                        this.myRegex = new Regex("xxx+");
                        values[i] = this.myRegex.Replace(values[i], "");
                        //--------------------------------------------------

                        switch (i)
                        {
                            case 1: // Raison sociale
                                this.myRegex = new Regex("");
                                if (!this.myRegex.IsMatch(values[i]))
                                {
                                    rap.ErrorMessages += "Raison Sociale : vide \r\n";
                                }
                                break;
                            case 2: // Adresse
                                this.myRegex = new Regex("");
                                if (!this.myRegex.IsMatch(values[i]))
                                {
                                    inserer = true;

                                }else
                                {
                                    rap.ErrorMessages += "Adresse : vide \r\n";
                                }
                                
                                break;
                            case 3: // CP
                                this.myRegex = new Regex("^[0-9]{5}$");
                                if (!this.myRegex.IsMatch(values[i]))
                                {
                                    values[i] = "";
                                    rap.ErrorMessages += "Code Postal : Incorect \r\n";
                                }
                                break;
                            case 4: // Ville
                                this.myRegex = new Regex("");
                                if (!this.myRegex.IsMatch(values[i]))
                                {
                                    rap.ErrorMessages += "Ville : vide \r\n";
                                }
                                break;
                            case 5: // Tel
                                
                                this.myRegex = new Regex("(\\.|\\-|,|\"|'| )");
                                values[i] = this.myRegex.Replace(values[i], "");

                                this.myRegex = new Regex("IDEM");
                                values[i] = this.myRegex.Replace(values[i], values[6]);

                                this.myRegex = new Regex("([a-z]+|[A-Z]+)");
                                values[i] = this.myRegex.Replace(values[i], "");

                                this.myRegex = new Regex("[0 - 9]{ 10}");
                                if (!this.myRegex.IsMatch(values[i]))
                                {
                                   values[i] = "";
                                   rap.ErrorMessages += "Téléphone : Incorect \r\n";
                                }
                                else
                                {
                                    inserer = true;
                                }

                                break;
                            case 6: // Fax
                                this.myRegex = new Regex("(\\.|\\-|,|\"|'| )");
                                values[i] = this.myRegex.Replace(values[i], "");

                                this.myRegex = new Regex("IDEM");
                                values[i] = this.myRegex.Replace(values[i], values[5]);

                                this.myRegex = new Regex("([a-z]+|[A-Z]+)");
                                values[i] = this.myRegex.Replace(values[i], "");

                                this.myRegex = new Regex("[0-9]{10}");
                                if (!this.myRegex.IsMatch(values[i]))
                                {
                                    values[i] = "";
                                    rap.ErrorMessages += "Fax : Incorect \r\n";
                                }
                                else
                                {
                                    inserer = true;
                                }
                                break;
                            case 7: // Email

                                values[i] = Regex.Replace(values[i], "[A-Z]*", m => " " + m.ToString().ToLower(), RegexOptions.IgnoreCase);
                                this.myRegex = new Regex(" ");
                                values[i] = this.myRegex.Replace(values[i], "");

                                this.myRegex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                                if (!this.myRegex.IsMatch(values[i]))
                                {
                                    values[i] = "";
                                    rap.NbInvalidEmail++;
                                    rap.ErrorMessages += "Email : Incorect \r\n";
                                }
                                else
                                {
                                    inserer = true;
                                }
                                break;
                            case 8: // Actif
                                this.myRegex = new Regex("((o|O)ui|(n|N)on)");
                                if (this.myRegex.IsMatch(values[i]))
                                {
                                    this.myRegex = new Regex("(o|O)ui");
                                    if (this.myRegex.IsMatch(values[i]))
                                    {
                                        values[i] = this.myRegex.Replace(values[i], "true");
                                    }
                                    else
                                    {
                                        this.myRegex = new Regex("(n|N)on");
                                        if (this.myRegex.IsMatch(values[i]))
                                        {
                                            values[i] = this.myRegex.Replace(values[i], "false");
                                            rap.ErrorMessages += "Le client est condidéré comme innactif car le champ est incorect \r\n";
                                        }     

                                    }


                                }else
                                {
                                    values[i] = "false";
                                }
                                
                                break;
                            case 9: // Reglement
                                this.myRegex = new Regex("");
                                if (!this.myRegex.IsMatch(values[i]))
                                {
                                    rap.ErrorMessages += "Reglement : Vide \r\n";
                                }
                                break;
                        }
                        values[i] = values[i].Replace("'", "");

                        laLigne.Add(values[i]); 
                        
                        }
                    
                    if (inserer) // Si la ligne peut etres inséré
                    {
                        lesData.Add(laLigne.ToList()); // On l'ajoute à la liste des ligne traité
                        ligne++; // on passe a la ligne suivante à inséré
                        inserer = false;   
                        rap.NbLignesInserees++; // Ajout d'une ligne traité au compteur
                    }else
                    {
                        rap.ErrorMessages += "LIGNE "+ actualLingne.ToString() + " n'a pas été insérée ! \r\n";
                    }
                    //Avant de passer à la prochaine ligne du csv
                    laLigne.Clear(); // On clear le list de ligne tempon  
                    rap.NbLignesTraitees++; // On incrémente le compteur de lignes taitées
                }
                
            }
            else
            {
                Console.WriteLine("Aucun fichier n'a été chargé !");
            }
            
            
            return lesData;
        }




    }
}
