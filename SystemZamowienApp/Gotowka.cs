using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemZamowienApp
{
    class Gotowka : Platnosc
    {
        public override void wydrukZamowienia()
        {
            base.wydrukZamowienia();
        }

        public override void zaplac()
        {
            Console.WriteLine("Forma zaplaty: GOTOWKA");
        }
    }
}
