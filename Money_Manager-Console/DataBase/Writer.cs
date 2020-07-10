using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Money_Manager_Console.Items;

namespace Money_Manager_Console.DataBase
{
    class Writer : IWriter
    {
        private string filename;

        public Writer(string filename1)
        {
            filename1 = filename;
        }

        public void Remove(int id)
        {
            IEnumerable<string> lines = File.ReadAllLines(filename);

            IList<string> toSave = new List<string>();

            foreach(string line in lines)
            {
                if(!HasId(id, line))
                {
                    toSave.Add(line);
                }
            }

            File.WriteAllLines(filename, toSave);
        }
        public void Write(Item item)
        {
            string line = ItemToText(item);

            File.WriteAllText(filename, line);
        }
        private string ItemToText(Item item)
        {
            string type = "Zysk";

            if(item.Type == ItemType.Outcome)
            {
                type = "Wydatek";
            }

            string line = string.Format("{0}; {1}; {2}, {3}; {4}",
                item.Id,
                item.Name,
                type,
                item.Amount,
                item.Date.ToString("dd-MM-yyyy"));

            return line + Environment.NewLine;
        }

        private bool HasId(int id, string line)
        {
            string[] table = line.Split(';');

            int lineId = int.Parse(table[0]);

            return id == lineId;
        }
    }
}
