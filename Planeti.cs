using Galaxy.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy
{
    class Planeti : LGalaxy
    {
        public string zvIme;
        public string ime;
        public PlanetType tip;
        public bool obitaemi;

        public Planeti() { }
        public Planeti(Zvezdi s, string ime, PlanetType tip, bool obitaemi)
        {
            this.zvIme = s.Ime;
            this.ime = ime;
            this.tip = tip;
            this.obitaemi = obitaemi;
        }
        public string Ime
        {
            get { return this.ime; }
            set { this.ime = value; }
        }
        public PlanetType Tip
        {
            get { return this.tip; }
            set { this.tip = value; }
        }
        public bool Obitaemi
        {
            get { return this.obitaemi; }
            set { this.obitaemi = value; }
        }
    }
}
