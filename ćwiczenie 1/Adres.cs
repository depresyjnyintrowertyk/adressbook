using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ćwiczenie_1
{
    internal class Adres
    {
     
        public string Ulica { get; private set; }
        public string NumerDomu { get; private set; }
        public string NumerMieszkania { get; private set; }
        public string KodPocztowy { get; private set; }
        public string Miasto  { get; private set; }
        public string Państwo { get; private set; }
        public Adres(string ulica, string numerDomu, string numerMieszkania, string kodPocztowy, string miasto, string państwo)
        {
            this.Ulica = ulica;
            this.NumerDomu = numerDomu;
            this.NumerMieszkania= numerMieszkania;
            this.KodPocztowy = kodPocztowy;
            this.Miasto = miasto;
            this.Państwo = państwo;

         
        }
        public string AdresPocztowy
        {
            get {
                if (string.IsNullOrWhiteSpace(NumerMieszkania))
                   return $"ul. {Ulica} {NumerDomu}\n{KodPocztowy} {Miasto}\n{Państwo}";
                else return $"ul. {Ulica} {NumerDomu}/{NumerMieszkania}\n{KodPocztowy} {Miasto}\n{Państwo}";
            }
        }



    }
}
