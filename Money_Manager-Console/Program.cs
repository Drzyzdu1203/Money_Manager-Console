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
            string key;
            int i = 1;
            DisplayMenu();

            while (i > 0)
            {
                
                selected = Console.ReadLine();

                if (selected == "1")
                {
                    Lista();
                    key = Console.ReadLine();
                    if (key == "1")
                    {
                        DisplayMenu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Ten klawisz nie ma przypisanej żadnej funkcji. \n");
                        Console.WriteLine("1 - Powrót do menu");
                        
                    }
                    continue;
                }
                if (selected == "2")

                {
                    Raport();
                    continue;
                }
                if (selected == "3")
                {
                    Dochod();
                    continue;
                }
                if (selected == "4")
                {
                    Wydatek();
                    continue;
                }
                if (selected == "5")
                {
                    Usun();
                    continue;
                }
                if (selected == "6")
                {
                    Zakoncz();
                }
                else
                {
                    Console.Clear();
                    Console.Write("Ten klawisz nie ma przypisanej żadnej funkcji.");
                }
            }
            Console.ReadKey();
        }
        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Lista");
            Console.WriteLine("2 - Raport miesięczny");
            Console.WriteLine("3 - Dodaj dochód");
            Console.WriteLine("4 - Dodaj wydatek");
            Console.WriteLine("5 - Usuń pozycje");
            Console.WriteLine("6 - Zakończ");
        }
        static void Lista()
        {
            
            Console.Clear();
            Console.WriteLine("Lista\n");
            Console.WriteLine("1 - Powrót");
           

        }
        static void Raport()
        {
            Console.Clear();
            Console.WriteLine("Raport miesięczny");
        }
        static void Dochod()
        {
            Console.Clear();
            Console.WriteLine("Dochody");
        }
        static void Wydatek()
        {
            Console.Clear();
            Console.WriteLine("Wydatki");
        }
        static void Usun()
        {
            Console.Clear();
        }
        static void Zakoncz()
        {
            Environment.Exit(0);
        }
    }
}
