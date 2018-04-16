using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemZamowienApp
{
    class Przelew : Platnosc
    {
        public override void zaplac()
        {
            Console.WriteLine("Forma zaplaty: PRZELEW");
        }
    }
}
