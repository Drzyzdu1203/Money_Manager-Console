using Money_Manager_Console.DataBase;
using Money_Manager_Console.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Manager_Console.Statistics
{
    class Summary
    {
        private IReader reader;

        public Summary(IReader reader1)
        {
            reader = reader1;
        }

        public void DisplayRaport(int year, int month)
        {
            IEnumerable<Item> list = GetItems(year, month);

            decimal incomes = SumaIncomes(list);
            decimal outcomes = SumaOutcomes(list);

            decimal balance = Balance(incomes, outcomes);

            Console.WriteLine("Podsumowanie {0}/{1}", month, year);
            Console.WriteLine("Suma dochodów: {0}zł", incomes);
            Console.WriteLine("Suma wydatków: {0}zł", outcomes);
            Console.WriteLine("______________________");
            Console.WriteLine("Bilans: {0}zł", balance);
        }

        private IEnumerable<Item> GetItems(int year, int month)
        {
            IEnumerable<Item> list = reader.ReadAll();

            List<Item> reportList = new List<Item>();

            foreach (Item item in list)
            {
                if (item.Date.Year == year && item.Date.Month == month)
                {
                    reportList.Add(item);
                }
            }
            return reportList;
        }

        private decimal SumaIncomes(IEnumerable<Item> list)
        {
            decimal suma = 0.0M;

            foreach (Item item in list)
            {
                if (item.Type == ItemType.Income)
                {
                    suma += item.Amount;
                }
            }

            return suma;
        }
        private decimal SumaOutcomes(IEnumerable<Item> list)
        {
            decimal suma = 0.0M;

            foreach (Item item in list)
            {
                if (item.Type == ItemType.Outcome)
                {
                    suma += item.Amount;
                }
            }

            return suma;
        }

        private decimal Balance(decimal incomes, decimal outcomes)
        {
            return incomes - outcomes;
        }
    }
}
