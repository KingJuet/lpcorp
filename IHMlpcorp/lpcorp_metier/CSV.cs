using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lpcorp_metier
{
    public class CSV
    {
        private string filePath; 
        private List<List<string>> data;
        private StreamReader reader;

      

        public CSV(string path)
        {
            this.filePath = path;
            this.reader = new StreamReader(path);
            this.data = new List<List<string>>();
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
                            case 0: // Code
                                break;
                            case 1: // Raison social
                                break;
                            case 2: // Adresse
                                break;
                            case 3: // CP
                                break;
                            case 4: // Ville
                                break;
                            case 5: // Tel
                                break;
                            case 6: // Fax
                                break;
                            case 7: // Email
                                break;
                            case 8: // Actif
                                break;
                            case 9: // Reglement
                                break;
                        }
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
