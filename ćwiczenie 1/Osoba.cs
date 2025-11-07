using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ćwiczenie_1
{
    internal class Osoba
    {
        
        public string Imię { get; private set; }
        public string Nazwisko { get; private set; }
        public Adres Adres { get; private set; }
        
        public void Przedstawsię()
        {
            Console.WriteLine( $"{Imię} {Nazwisko}");
            Console.WriteLine(Adres.AdresPocztowy);

        }
        public void UstawDane(string imię, string nazwisko, string ulica, string numerDomu, string numerMieszkania, string kodPocztowy, string miasto, string państwo)
        {
            this.Imię = imię;
            this.Nazwisko = nazwisko;
            
                this.Adres = new Adres(ulica, numerDomu, numerMieszkania, kodPocztowy, miasto, państwo);
         
            
        }
        
    }
}
