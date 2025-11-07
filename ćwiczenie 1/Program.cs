using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ćwiczenie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "książka adresowa";
            //Osoba osoba = new Osoba();
            //osoba.Imię = "Maria";
            //osoba.Nazwisko = "Halamska";


            /*osoba.UstawDane("Mała", "Babała", "aaaa", "ddddd", "cccc", "dsd", "sdwd", "asdw");
              osoba.Przedstawsię();*/

            Console.WriteLine("Podaj ilość kontaktów");

            int.TryParse(Console.ReadLine(), out int kontakty);
            List<Osoba> Osoby = new List<Osoba>();
            for (int i = 0; i < kontakty; i++)
            {

                Console.WriteLine($"osoba{i + 1}");
                Console.WriteLine("Imię:");
                string imię = Console.ReadLine();
                Console.WriteLine("Nazwisko");
                string nazwisko = Console.ReadLine();
                Console.WriteLine("Ulica");
                string ulica = Console.ReadLine();
                Console.WriteLine("Numer Domu");
                string numerDomu = Console.ReadLine();
                Console.WriteLine("Numer Mieszkania");
                string numerMieszkania = Console.ReadLine();
                Console.WriteLine("Kod Pocztowy");
                string kodPocztowy = Console.ReadLine();
                Console.WriteLine("Miasto");
                string miasto = Console.ReadLine();
                Console.WriteLine("Państwo");
                string państwo = Console.ReadLine();

                Osoby.Add(new Osoba());
                Osoby[i].UstawDane(imię, nazwisko, ulica, numerDomu, numerMieszkania, kodPocztowy, miasto, państwo);
                Console.Clear();
            }
            string taknie;
            do
            {
                Console.Clear();
                Console.WriteLine("Wybierz osobę ");

                for (int i = 0; i < Osoby.Count; i++)
                {

                    Console.WriteLine($"{i + 1} {Osoby[i].Imię} {Osoby[i].Nazwisko}");
                }

                int wyborOsoby = Convert.ToInt32(Console.ReadLine());
                wyborOsoby = wyborOsoby - 1;

                Osoby[wyborOsoby].Przedstawsię();
                Console.WriteLine("Kontynuować? T/N");
                taknie = Console.ReadLine();
            }
            while (taknie !="N");

        }
    }
}
