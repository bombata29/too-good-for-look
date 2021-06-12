using Galaxy.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy
{
    class Galaksiq : LGalaxy
    {
       public string ime;
        public GalaxyType tip;
        public string godini;

        public Galaksiq() { }
        public Galaksiq(string ime, GalaxyType tip, string godini)
        {
            this.ime = ime;
            this.tip = tip;
            this.godini = godini;
        }
        public string Ime
        {
            get { return this.ime; }
            set { this.ime = value; }
        }
        public GalaxyType Tip
        {
            get { return this.tip; }
            set { this.tip = value; }
        }
        public string Godini
        {
            get { return this.godini; }
            set { this.godini = value; }
        }

    }
}

