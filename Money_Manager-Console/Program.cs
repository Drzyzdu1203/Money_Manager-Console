using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Manager_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string selected;
            do
            {
                DisplayMenu();
                selected = Console.ReadLine();
                RunSelected(selected);
            }
            while (selected !="6");
            
        
            
        }
        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Lista");
            Console.WriteLine("2 - Raport miesięczny");
            Console.WriteLine("3 - Dodaj dochód");
            Console.WriteLine("4 - Dodaj wydatek");
            Console.WriteLine("5 - Usuń pozycje");
            Console.WriteLine("6 - Zakończ");
            Console.WriteLine("\nWybrana opcja:");
        }

        private static void RunSelected(string selected)
        {
            switch(selected)

            {
                case "1":
                    ShowList();

                    break;

                case "2":
                    ShowRaport();
                    break;

                case "3":
                    AddIncome();
                    break;

                case "4":
                    AddOutcome();
                    break;
                    
                case "5":
                    RemoveItem();
                    break;
            }
        }
        static void ShowList()
        {
            Console.Clear();
            
        }
        static void ShowRaport()
        {
            Console.Clear();
        }
        static void AddIncome()
        {
            Console.Clear();
        }
        static void AddOutcome()
        {
            Console.Clear();
        }
        static void RemoveItem()
        {
            Console.Clear();
        }


    }
}
