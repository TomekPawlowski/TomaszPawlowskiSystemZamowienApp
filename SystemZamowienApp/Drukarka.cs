using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemZamowienApp
{
    class Drukarka : INotatka
    {
        public void wydrukPotwierdzenia()
        {
            Console.WriteLine("Wydruk potwierdzenia");
        }
    }
}
