using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInteraktywnie
{
    class Program
    {
        static void Main(string[] args)
        {
            // tu piszemy kod
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Program EMERYTURA");
            Console.Write("Podaj swoje imię: ");
            string imie;
            imie = Console.ReadLine().Trim().ToUpper();
            //imie = imie.Trim();

            Console.Write("Podaj swoje nazwisko: ");
            string nazwisko = Console.ReadLine().Trim();
            
            string pierwszaLitera = nazwisko.Substring(0,1);
            string reszta = nazwisko.Substring(1);
            nazwisko = pierwszaLitera.ToUpper() + reszta.ToLower();

            //Console.WriteLine("Witaj, " + imie + " " + nazwisko + "!");
            //Console.WriteLine("Witaj, {0} {1}!", nazwisko, imie); //formatted string
            Console.WriteLine($"Witaj, {imie} {nazwisko}!");

            Console.Write("Podaj swój wiek: ");
            int wiek;
            string s = Console.ReadLine();
            wiek = int.Parse(s);

            Console.WriteLine($"Masz {wiek} lat.");

            //jezeli wiek > 67 to jestes emerytem
            //a w przecinym przypadku do emerytury zostało Ci 67-wiek lat
            if( wiek >= 67 )
            {
                Console.WriteLine(" jesteś emerytem");
            }
            else
            {
                Console.WriteLine($" do emerytury zostało ci {67-wiek} lat");
            }

        }
    }
}
