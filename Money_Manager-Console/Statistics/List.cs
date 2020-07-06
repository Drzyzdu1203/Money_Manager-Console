using Money_Manager_Console.DataBase;
using Money_Manager_Console.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Manager_Console.Statistics
{
    class List
    {
        private IReader reader1;
         
        public List(IReader reader)
        {
            reader1 = reader;
        }

        public void DisplayList()
        {
            IEnumerable<Item> list = reader1.ReadAll();

            foreach(Item item in list)
            {
                DisplayLine(item);
            }
        }

        private void DisplayLine(Item item)
        {
            Console.WriteLine("{0} {1} {2}zł {3}", item.Id, item.Name, item.Amount, item.Date);
        }
    }
}
