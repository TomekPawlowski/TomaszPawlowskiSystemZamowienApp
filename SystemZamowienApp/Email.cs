using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemZamowienApp
{
    class Email: INotatka
    {
        public string AdresEmail { get; set; }


        public Email(string adresEmail)

        {
            this.AdresEmail = adresEmail;

        }
        public void wydrukPotwierdzenia()
        {
            Console.WriteLine("Potwierdzenie wyslane emailem na adres: {0}", AdresEmail);
        }
    }
}
