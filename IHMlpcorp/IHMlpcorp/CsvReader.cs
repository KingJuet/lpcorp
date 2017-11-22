using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHMlpcorp
{
    public class CsvReader
    {
        private string filePath;
        private StreamReader reader;
        private Dictionary<string, List<string>> data;
        private string[] columne;
        public CsvReader()
        {
            this.filePath = "null";
        }
        public CsvReader(string[] col)
        {
            data = new Dictionary<string, List<string>>();
            this.columne = col;
            foreach(string s in this.columne)
            {
                this.data.Add(s, new List<string>());
            }
        }

        public void LoadFile(string path)
        {
            this.filePath = path;
            this.reader = new StreamReader(path);
        }
        public string GetFilePath()
        {
            return this.filePath;
        }
        
        public void Read()
        {
   
            if (this.filePath != "null")
            {
                while (!reader.EndOfStream)
                {

                    string line = reader.ReadLine();
                    string[] values = line.Split(';');

                    for(int i=0; i<this.columne.Length; i++)
                    {

                        this.data[this.columne[i]].Add(values[i]);

                    }

                }
            }
            else
            {
                Console.WriteLine("Aucun fichier n'a été charger !");
            }
        }

        public Dictionary<string, List<string>> GetData()
        {
            return this.data;
        }


    }
}
