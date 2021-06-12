using Galaxy.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy
{
    class Zvezdi : LGalaxy
    {
        public string glIme;
        public string ime;
        public ClassStars tip;
        public decimal godini;
        public decimal mass;
        public decimal razmer;
        public int temp;
        public decimal svetimost;

        public Zvezdi() { }
        public Zvezdi(Galaksiq galaxy, string ime, decimal mass, decimal razmer, int temp, decimal svetimost)
        {
            this.glIme = galaxy.Ime;
            this.ime = ime;
            this.mass = mass;
            this.razmer = razmer;
            this.temp = temp;
            this.svetimost = svetimost;
        }
        public string Ime
        {
            get { return this.ime; }
            set { this.ime = value; }
        }
        public ClassStars Tip
        {
            get { return this.tip; }
            set { this.tip = value; }
        }
        public decimal Godini
        {
            get { return this.godini; }
            set { this.godini = value; }
        }
        public decimal Mass
        {
            get { return this.mass; }
            set { this.mass = value; }
        }
        public decimal Razmer
        {
            get { return this.razmer; }
            set { this.razmer = value; }
        }
        public int Temp
        {
            get { return this.temp; }
            set { this.temp = value; }
        }
        public decimal Svetimost
        {
            get { return this.svetimost; }
            set { this.svetimost = value; }
        }
    }
}
