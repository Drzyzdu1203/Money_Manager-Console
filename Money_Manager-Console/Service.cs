using System;
using Money_Manager_Console.Items;
using Money_Manager_Console.DataBase;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Manager_Console
{
    class Service
    {
        private IReader _reader;
        private IWriter _writer;

        public Service(IReader reader, IWriter writer)
        {
            _reader = reader;
            _writer = writer;
        }

        public void AddIncome(decimal amount, string name, DateTime date)
        {
            int id = _reader.GetNextId();

            Income income = new Income(id, amount, name, date);

            _writer.Write(income);
        }
        public void AddOutcome(decimal amount, string name, DateTime date)
        {
            int id = _reader.GetNextId();

            Outcome income = new Outcome(id, amount, name, date);

            _writer.Write(income);
        }
        public void RemoveById(int id)
        {
            _writer.Remove(id);
        }
    }
}
