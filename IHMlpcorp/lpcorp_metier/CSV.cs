﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Mail;
namespace lpcorp_metier
{
    public class CSV
    {
        private string filePath; 
        private StreamReader reader;
        private Regex myRegex;
      

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


        public List<List<string>> Formater(Rapport rap)
        {
            string isAPhone = "[0-9]{10}";
            string delete = "(\\.|\\-|,|\"|'| )";
            string containeChars = "([a-z]+|[A-Z]+)";
            string idem = "IDEM";
            List<List<string>> lesData = new List<List<string>>();
            List<string> laLigne = new List<string>();
            bool inserer = false;
            int ligne = 0;
            if (this.filePath != "null")
            {
                while (!reader.EndOfStream)
                {

                    string line = reader.ReadLine();
                    string[] values = line.Split(';');



                        for (int i = 0; i < values.Length; i++)
                        {
                        switch (i)
                        {
                            case 1: // Raison social
                                break;
                            case 2: // Adresse
                                this.myRegex = new Regex("");
                                if (!this.myRegex.IsMatch(values[i]))
                                {
                                    inserer = true;
                                }
                                
                                break;
                            case 3: // CP
                                this.myRegex = new Regex("^[0-9]{5}$");
                                if (!this.myRegex.IsMatch(values[i]))
                                {
                                    values[i] = "";
                                }
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
                                else
                                {
                                    inserer = true;
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

                        laLigne.Add(values[i]);
                        
                        }
                    if (inserer)
                    {
                        lesData.Add(laLigne.ToList());
                        ligne++;
                        inserer = false;
                        rap.NbLignesInserees++;
                    }
                    laLigne.Clear();
                    rap.NbLignesTraitees++;
                }
                
            }
            else
            {
                Console.WriteLine("Aucun fichier n'a été chargé !");
            }
            
            //Console.WriteLine(this.data[1].Count.ToString());
            return lesData;
        }




    }
}
