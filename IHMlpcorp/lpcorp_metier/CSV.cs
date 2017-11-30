using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace lpcorp_metier
{
    public class CSV
    {
        private string filePath; 
        private List<List<string>> data;
        private StreamReader reader;
        private Regex myRegex;
      

        public CSV(string path)
        {
            this.filePath = path;
            this.reader = new StreamReader(path);
            this.data = new List<List<string>>();
            myRegex = new Regex("([a-z]+|[A-Z]+)");
        }


        public string GetFilePath()
        {
            return this.filePath;
        }

        public List<List<string>> GetData()
        {
            return this.data;
        }

        public List<List<string>> Formater()
        {
            string isAPhone = "[0-9]{10}";
            string delete = "(\\.|\\-|,|\"|'| )";
            string containeChars = "([a-z]+|[A-Z]+)";
            string idem = "IDEM";
            List<List<string>> lesData = new List<List<string>>();
            int ligne = 0;
            if (this.filePath != "null")
            {
                while (!reader.EndOfStream)
                {

                    string line = reader.ReadLine();
                    string[] values = line.Split(';');


                        lesData.Add(new List<string>());
                        for (int i = 0; i < values.Length; i++)
                        {
                        switch (i)
                        {
                            case 1: // Raison social
                                break;
                            case 2: // Adresse
                                break;
                            case 3: // CP
                                this.myRegex = new Regex("[0-9]{5}");
                                if (!this.myRegex.IsMatch(values[i]))
                                {
                                    values[i] = "";
                                }
                                values[i] = this.myRegex.Replace(values[i], "");
                                break;
                            case 4: // Ville
                                break;
                            case 5: // Tel
                                
                                this.myRegex = new Regex(delete);
                                values[i] = this.myRegex.Replace(values[i], "");

                                this.myRegex = new Regex(idem);
                                values[i] = this.myRegex.Replace(values[i], values[6]);

                                this.myRegex = new Regex(containeChars);
                                values[i] = this.myRegex.Replace(values[i], "");

                                this.myRegex = new Regex(isAPhone);
                                if (!this.myRegex.IsMatch(values[i]))
                                {
                                values[i] = "";
                                }

                                break;
                            case 6: // Fax
                                this.myRegex = new Regex(delete);
                                values[i] = this.myRegex.Replace(values[i], "");

                                this.myRegex = new Regex(idem);
                                values[i] = this.myRegex.Replace(values[i], values[5]);

                                this.myRegex = new Regex(containeChars);
                                values[i] = this.myRegex.Replace(values[i], "");

                                this.myRegex = new Regex(isAPhone);
                                if (!this.myRegex.IsMatch(values[i]))
                                {
                                    values[i] = "";
                                }
                                break;
                            case 7: // Email
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
                                        }     

                                    }


                                }else
                                {
                                    values[i] = "false";
                                }
                                
                                break;
                            case 9: // Reglement
                                break;
                        }
                        values[i] = values[i].Replace("'", "");
                        //values[i] = values[i].Replace("\"", "");
                        //values[i] = values[i].Replace(".", "");
                        //values[i] = values[i].Replace("-", "");
                        //values[i] = values[i].Replace(",", "");
                        lesData[ligne].Add(values[i]);
                        }
                    ligne++;
                }
            }
            else
            {
                Console.WriteLine("Aucun fichier n'a été chargé !");
            }
            this.data = lesData;
            return lesData;
        }




    }
}
