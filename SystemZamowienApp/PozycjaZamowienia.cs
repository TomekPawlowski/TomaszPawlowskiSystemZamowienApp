using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemZamowienApp
{
   public class PozycjaZamowienia
    {

        public static string NazwaTowaru { get; set; }
        public static int Ilosc { get; set; }
    
        public static float CenaJednostkowa { get; set; }

        public static int StawkaVat { get; set; }
       

        public static double obliczBrutto()

        {
           return  Ilosc * CenaJednostkowa; 
        }

        public static double obliczPodatek()
        {
            return (double)(StawkaVat)/100 * obliczBrutto();

        }
    }
}

