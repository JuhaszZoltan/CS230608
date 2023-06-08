using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtasszallitokCLI
{
    internal class Repulogeptipus
    {
        public string Nev { get; set; }
        public int Ev { get; set; }
        public string UtasString { get; set; }
        public (int? Min, int Max) Utas
        {
            get
            {
                if (UtasString.Contains('-'))
                {
                    var us = UtasString.Split('-');
                    return (int.Parse(us[0]), int.Parse(us[1]));
                }
                else return (null, int.Parse(UtasString));
            }
        }
        public string SzemelyzetString { get; set; }
        public (int? Min, int Max) Szemelyzet
        {
            get
            {
                if (SzemelyzetString.Contains('-'))
                {
                    var szs = SzemelyzetString.Split('-');
                    return (int.Parse(szs[0]), int.Parse(szs[1]));
                }
                else return (null, int.Parse(SzemelyzetString));
            }
        }
        public int Utazosebesseg { get; set; }
        public int Felszallotomeg { get; set; }
        public float Fesztav { get; set; }
        public string Sebessegkategoria 
            => new Sebessegkategoria(Utazosebesseg).Kategorianev;

        public Repulogeptipus(string r)
        {
            var splts = r.Split(';');
            Nev = splts[0];
            Ev = int.Parse(splts[1]);
            UtasString = splts[2];
            SzemelyzetString = splts[3];
            Utazosebesseg = int.Parse(splts[4]);
            Felszallotomeg = int.Parse(splts[5]);
            Fesztav = float.Parse(splts[6]);
        }

    }
}
