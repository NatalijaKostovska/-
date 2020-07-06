using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankomat_proekt
{
    public class Korisnik
    {

        public string ime { get; set; }
        public string prezime { get; set; }
        public string pin { get; set; }
        public float suma { get; set; }
        public Korisnik(string ime = "",string prezime = "", string pin = "", float suma = 0)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.pin = pin;
            this.suma = suma;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", ime, prezime);

        }
    }
}
