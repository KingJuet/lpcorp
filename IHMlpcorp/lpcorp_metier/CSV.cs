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
        private StreamReader reader;
        public CSV(string path)
        {
            this.filePath = path;
            this.reader = new StreamReader(path);
        }


        public string GetFilePath()
        {
            return this.filePath;
        }

        public void ExtractData()
        {

            if (this.filePath != "null")
            {
                while (!reader.EndOfStream)
                {

                    string line = reader.ReadLine();
                    string[] values = line.Split(';');

                    for (int i = 0; i < this.columne.Length; i++)
                    {

                        this.data[this.columne[i]].Add(values[i]);

                    }

                }
            }
            else
            {
                Console.WriteLine("Aucun fichier n'a été chargé !");
            }
        }

 


    }
}
