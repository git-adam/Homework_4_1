using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Program ma za zadanie określić czy wprowadzona liczba jest parzysta.");
            Console.Write("Podaj liczbę: ");
            while (true)
            {
                
                var number = GetNumber();

                if (number % 2 == 0)
                {
                    Console.WriteLine("Podana liczba jest parzysta.");
                }
                else
                {
                    Console.WriteLine("Podana liczba jest nieparzysta.");
                }

                Console.Write("Aby zakończyć program wciśnij 't' lub podaj nową liczbę: ");

            }
        }

        private static int GetNumber()
        {
            while (true)
            {
                var val = Console.ReadLine();

                if (val.ToUpper() == "T")
                    Environment.Exit(0);

                if (!int.TryParse(val, out int number))
                {                
                    Console.WriteLine("Nieprawidłowe dane, spróbuj jeszcze raz.");
                    continue;
                }

                return number;
            }

        }
    }

}
