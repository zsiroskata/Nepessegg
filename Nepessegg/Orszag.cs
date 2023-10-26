using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepessegg
{
    internal class Orszag
    {
        public string Orszagnev { get; private set; }
        public int Terulet { get; private set; }
        public int Nepesseg { get; private set; }
        public string Fovaros { get; private set; }
        public int FovarosNepesseg { get; private set; }

        public Orszag(string orszagnev, int terulet, int nepesseg, string fovaros, int fovarosNepesseg)
        {
            Orszagnev = orszagnev;
            Terulet = terulet;
            Nepesseg = nepesseg;
            Fovaros = fovaros;
            FovarosNepesseg = fovarosNepesseg;
        }

        public Orszag(string sor)
        {
            var v = sor.Split(';');
            Orszagnev = v[0];
            Terulet = int.Parse(v[1]);
            Nepesseg = int.Parse(v[2].Replace("g", "0000"));
            Fovaros = v[3];
            FovarosNepesseg = int.Parse(v[4]);
        }

        public override string ToString()
        {
            return "";
        }
    }

}
