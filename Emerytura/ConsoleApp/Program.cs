using System;

namespace ConsoleApp
{
    class Program
    {
        const int WiekEmerytalny = 70;

    
    
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj!");
            Console.Write("Podaj imię: ");
            string imię; //deklaracja zmiennej
            imię = Console.ReadLine(); //przypisanie

            Console.Write("Podaj nazwisko: "); // cw Tab Tab- Code Snippet
            string nazwisko = Console.ReadLine().ToUpper(); // deklaracja z inicjalizacją 
            //nazwisko = nazwisko.ToUpper(); 


            Console.WriteLine("Witaj" + imię + " " + nazwisko); // konkatenacja napisów za pomocą +
            Console.WriteLine("Witaj {0} {1}!", imię, nazwisko); // formatowany string
            Console.WriteLine($"Witaj {imię} {nazwisko}!!"); // string interpolowany


            Console.Write("Podaj swój wiek:");
            string linia = Console.ReadLine();
            //int wiek = int.Parse(linia); //parsowanie napisu do liczby całkowitej
            int wiek = Convert.ToInt32(linia);// równoważny sposób
            if (wiek > WiekEmerytalny )
            {
                Console.WriteLine("Jesteś emerytem");

            }
            else
            {
                Console.WriteLine($"Do emerytury zostało Ci lat: {WiekEmerytalny - wiek}");
            }


        }

        }
    }

