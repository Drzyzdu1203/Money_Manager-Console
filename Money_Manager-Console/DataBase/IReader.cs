﻿using Money_Manager_Console.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Money_Manager_Console.DataBase
{
    interface IReader
    {
        IEnumerable<Item> ReadAll();
        int GetNextId();
    }
}
