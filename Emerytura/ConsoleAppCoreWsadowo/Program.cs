// Aplikacja w .Net Core
// aplikacja działa w trybie wsadowym, wykorzystuje parametry
// przekazane w linii komend
// Przykład uzycia: app.exe Imie Nazwisko Wiek

using System;

namespace ConsoleAppCoreWsadowo
{
    class Program
    {
        const int WiekEmerytalny = 67;

        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("za mało parametrów. Wymagane 3");
                return; //wychodzę, koniec programu
            }

            string imie = args[0];
            string nazwisko = args[1];
            int wiek = int.Parse( args[2] );

            Console.WriteLine($"Witaj, {imie} {nazwisko}!");
           
            Console.WriteLine($"Masz {wiek} lat.");
            if( wiek >= WiekEmerytalny )
                Console.WriteLine("jesteś emerytem");
            else
                Console.WriteLine($"do emerytury zostało Ci {WiekEmerytalny - wiek} lat!");
        }
    }
}
