using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemZamowienApp
{

    public abstract class Platnosc
    {
        protected int KwotaPlatnosci { get; set; }


        public abstract void zaplac();


        public virtual void wydrukZamowienia()
        {
            Console.WriteLine("Zamowienie jest drukowane");
        }

    }

}
