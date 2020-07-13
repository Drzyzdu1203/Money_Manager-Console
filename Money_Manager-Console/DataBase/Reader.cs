﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Money_Manager_Console.Items;

namespace Money_Manager_Console.DataBase
{
    class Reader : IReader
    {
        private string _filename;
        

        public Reader(string filename)
        {
            _filename = filename;
        }

        public int GetNextId()
        {
            IEnumerable<Item> items = ReadAll();

            if (items.Count() == 0)
            {
                return 1;
            }

            int lastIndex = items.Count() - 1;

            return items.ElementAt(lastIndex).Id + 1;
        }

       

        public IEnumerable<Item> ReadAll()
        {
            
            IList<Item> items = new List<Item>();

            if(!File.Exists(_filename))
            {
                return items;
            }

            IEnumerable<string> lines = File.ReadAllLines(_filename);

            foreach (string line in lines)
            {
                Item item = TextToItem(line);
                items.Add(item);
            }

            return items;
        }
        private Item TextToItem(string line)
        {
            string[] table = line.Split(';');

            int id = int.Parse(table[0]);
            string name = table[1];
            string type = table[2];
            decimal amount = decimal.Parse(table[3]);
            DateTime date = DateTime.ParseExact(table[4], "dd-MM-yyyy", null);

            if (type == "I")
            {
                return new Income(id, amount, name, date);
            }

            return new Outcome(id, amount, name, date);
        }

    }
}
