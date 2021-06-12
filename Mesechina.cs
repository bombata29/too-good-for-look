using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy
{
    class Mesechina : LGalaxy
    {
        public string plIme;
        public string ime;
        public Mesechina() { }
        public Mesechina(Planeti p,string ime)
        {
            this.plIme = p.Ime;
            this.ime = ime;
        }
        public string Ime
        {
            get { return this.ime; }
            set { this.ime = value; }
        }
    }
}
