using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Money_Manager_Console.Items;
using Money_Manager_Console.Statistics;
using Money_Manager_Console.DataBase;

namespace Money_Manager_Console.DataBase.Files
{
    class File : IReader, IWriter
    {
        private IList<Item> list1;

        public File()
        {
            list1 = new List<Item>();
        }
        public void Write(Item item)
        {
            list1.Add(item);
        }
        public void Remove(int id)
        {
            Item toRemove = null;
            foreach (Item item in list1)
            {
                if (item.Id == id)
                {
                    toRemove = item;
                    break;
                }
            }
            list1.Remove(toRemove);
        }
        public IEnumerable<Item> ReadAll()
        {
            return list1;
        }
        public int GetNextId()
        {
            if(list1.Count == 0)
            {
                return 1;
            }
            int lastIndex = list1.Count - 1;
            return list1[lastIndex].Id + 1;
        }

       
    }
}
