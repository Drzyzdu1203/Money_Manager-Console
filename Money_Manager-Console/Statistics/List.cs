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
        private IReader reader;
         
        public List(IReader reader1)
        {
            reader = reader1;
        }

        public void DisplayList()
        {
            IEnumerable<Item> list = reader.ReadAll();

            foreach(Item item in list)
            {
                DisplayLine(item);
            }
        }

        private void DisplayLine(Item item)
        {
            string type = "";

            switch (item.Type)
            {
                case ItemType.Income:
                    type = "| Dochód |";
                    break;
                case ItemType.Outcome:
                    type = "| Wydatek |";
                    break;
            }

            Console.WriteLine("{0} {1} {2} {3}zł {4}", item.Id, item.Name, type, item.Amount, item.Date);
        }
    }
}
