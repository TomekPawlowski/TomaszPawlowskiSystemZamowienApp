using System;
using System.Collections;
using System.Collections.Generic;

namespace SystemZamowienApp
{
    public class Zamowienie
    {
       
 
      
        public static int numerZamowienia = 0;
        public static DateTime DataRealizacji { get; set; }
        public static bool statusZamowienia = false;
        public static string IdentyfikatorZamowienia { get; set; }
        public static ArrayList lista_pozycjiZamowienia = new ArrayList();
        public bool potwierdzenieElektroniczne { get; set; }

      

        public double wartoscZamowienia()
        {
            return PozycjaZamowienia.obliczBrutto();
        }

        public double wartoscPodatku()
        {
            return PozycjaZamowienia.obliczPodatek();
        }

        public bool oplacZamowienie(Platnosc platnosc)
        {

            IdentyfikatorZamowienia = "oplacone";
            return statusZamowienia = true;
        }

        public void drukujPotwierdzenie()

        {
            INotatka notatka = null;
            string adresEmail = "adresEmail@email.com";
         

            if (potwierdzenieElektroniczne == true)

            {
                notatka = new Email(adresEmail);

                    }

            else
                notatka = new Drukarka();

            notatka.wydrukPotwierdzenia();

        }

       

        public bool dodajPozcyjeZamowienia()

        {
            if (statusZamowienia == true)
            {
                numerZamowienia++;
                lista_pozycjiZamowienia.Add("Numer zamowienia: " + numerZamowienia + "\n"+
                    "Czas rozpoczęcia realizacji: " + Zamowienie.DataRealizacji + "\n"+
                    "Wartosc zamowienia netto: " + wartoscZamowienia() + "\n" +
                    "Wartosc podatku: " + wartoscPodatku() + "\n"+
                    "Wartosc zamowienia brutto: "+ (wartoscZamowienia()+wartoscPodatku()));
                

            }
            Console.WriteLine();
            return statusZamowienia = false;

        }

        public void wyswietlWszystkieZamowienia()
        {
            Console.WriteLine("-------LISTA ZAMOWIEN---------");
            Console.WriteLine();
            foreach (var item in lista_pozycjiZamowienia)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
           
        }

        
    }
}