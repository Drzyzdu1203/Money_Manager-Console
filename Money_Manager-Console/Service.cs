using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Manager_Console
{
    class Service
    {
        private IReader reader1;
        private IWriter writer1;

        public Service(IReader reader, IWriter writer)
        {
            reader1 = reader;
            writer1 = writer;
        }

        public void AddIncome(decimal amount, string name, DateTime date)
        {
            int id = reader1.GetNextId();

            Income income = new Income(id, amount, name, date);

            writer1.Wriite(income);
        }
        public void AddOutcome(decimal amount, string name, DateTime date)
        {
            int id = reader1.GetNextId();

            Outcome income = new Outcome(id, amount, name, date);

            writer1.Write(income);
        }
        public void RemoveById(int id)
        {
            writer1.Remove(id);
        }
    }
}