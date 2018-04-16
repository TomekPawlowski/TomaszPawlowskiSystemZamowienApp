using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemZamowienApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Zamowienie zamowienie = new Zamowienie();
            
            
          
            while (true)
            {

                Console.WriteLine("Wybierz zamawiany towar: opony, hamulce");
                Console.Write("Wpisz nazwe towaru: ");
                PozycjaZamowienia.NazwaTowaru  = Console.ReadLine();
                Console.Write("Wpisz ilosc zamawianych sztuk: ");
                PozycjaZamowienia.Ilosc = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Prosze wpisac sposob oplaty zamówienia: gotowka, przelew lub kredyt");
                Console.Write("Wpisz sposob: ");
                string sposobPlatnosci = Console.ReadLine();
                Console.WriteLine();


              
                if(PozycjaZamowienia.NazwaTowaru == "opony")
                {
                    PozycjaZamowienia.CenaJednostkowa = 150;
                    PozycjaZamowienia.StawkaVat = 23;
                }

                else if(PozycjaZamowienia.NazwaTowaru =="hamulce")
                {
                    PozycjaZamowienia.CenaJednostkowa = 30;
                    PozycjaZamowienia.StawkaVat = 8; 
                }

                if (sposobPlatnosci == "gotowka")
                {
                    
                    Platnosc platnoscGotowka = new Gotowka();
                    platnoscGotowka.zaplac();
                    platnoscGotowka.wydrukZamowienia();
                    Console.WriteLine();
                    zamowienie.oplacZamowienie(platnoscGotowka);
                }

                else if (sposobPlatnosci == "przelew")
                {
                    Platnosc platnoscPrzelewem = new Przelew();
                    platnoscPrzelewem.zaplac();
                    platnoscPrzelewem.wydrukZamowienia();
                    Console.WriteLine();
                    zamowienie.oplacZamowienie(platnoscPrzelewem);
                    
                }

                else if (sposobPlatnosci == "kredyt")
                {

                    Platnosc wziecieKredytu = new Kredyt(5, "PKO", 5);
                    wziecieKredytu.zaplac();
                    wziecieKredytu.wydrukZamowienia();
                    zamowienie.potwierdzenieElektroniczne = true;
                    Console.WriteLine();
                    zamowienie.oplacZamowienie(wziecieKredytu);

                }


                Zamowienie.DataRealizacji = DateTime.Now;
                Console.WriteLine("Zamowiony towar: {0}", PozycjaZamowienia.NazwaTowaru.ToUpper());
                Console.WriteLine("Ilosc zamowionych sztuk: {0}", PozycjaZamowienia.Ilosc);
                Console.WriteLine("Status platnosci zamowienia: {0}",Zamowienie.IdentyfikatorZamowienia);
                zamowienie.drukujPotwierdzenie();
                zamowienie.dodajPozcyjeZamowienia();
                zamowienie.wyswietlWszystkieZamowienia();
                Console.WriteLine();



            }

        }
    }
}
