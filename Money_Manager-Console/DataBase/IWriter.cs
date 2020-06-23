using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Manager_Console.DataBase
{
    interface IWriter
    {
        void Write(Item item);
        void Remove(int id);

    }
}
