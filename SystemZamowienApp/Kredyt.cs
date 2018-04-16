using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemZamowienApp
{
    class Kredyt : Platnosc
    {
        public byte LiczbaRat { get; set; }
        public string Bank { get; set; }

        public float OprocentowanieRoczne { get; set; }

        public Kredyt(byte LiczbaRat,string Bank, float OprocentowanieRoczne)
        {
            this.LiczbaRat = LiczbaRat;
            this.Bank = Bank;
            this.OprocentowanieRoczne = OprocentowanieRoczne;


        }

        public override void wydrukZamowienia()
        {
            base.wydrukZamowienia();
            Console.WriteLine();
            Console.WriteLine("Liczba rat: " + LiczbaRat);
            Console.WriteLine("Bank: " +Bank);
            Console.WriteLine("Oprocentowanie: " + OprocentowanieRoczne);
            
        }

        public override void zaplac()
        {
            Console.WriteLine("Forma zaplaty: KREDYT");
        }
    }
}
