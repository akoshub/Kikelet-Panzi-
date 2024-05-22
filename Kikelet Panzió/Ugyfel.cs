using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kikelet_Panzió
{
    internal class Ugyfel
    {
        string azon;
        string nev;
        DateTime szuletes;
        string email;
        bool vip;

        public Ugyfel(string nev, DateTime szuletes, string email, bool vip)
        {
            this.azon = AzonositoLetrehozas(nev);
            this.Nev = nev;
            this.Szuletes = szuletes;
            this.Email = email;
            this.Vip = vip;
        }

        public string Azon { get => azon; set => azon = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Szuletes { get => szuletes; set => szuletes = value; }
        public string Email { get => email; set => email = value; }
        public bool Vip { get => vip; set => vip = value; }

        private string AzonositoLetrehozas(string nev)
        {
            return $"{nev}_{DateTime.Now.ToString("yyyyMMddhhmmss")}";
        }


    }

    internal class Szoba
    {
        int szobaszam;
        int ferohelyekszama;
        int aregyfore;

        public Szoba(int szobaszam, int ferohelyekszama, int aregyfore)
        {
            this.Szobaszam = szobaszam;
            this.Ferohelyekszama = ferohelyekszama;
            this.Aregyfore = aregyfore;
        }

        public int Szobaszam
        {
            get => szobaszam;
            set
            {
                if (value >= 1 && value <= 6)
                {
                    szobaszam = value;
                }
            }
        }
        public int Ferohelyekszama
        {
            get => ferohelyekszama;
            set
            {
                if (value >= 1 && value <= 4)
                {
                    ferohelyekszama = value;
                }
            }
        }
        public int Aregyfore
        {
            get => aregyfore;
            set
            {
                if (value >= 6000 && value <= 12000)
                {
                    aregyfore = value;
                }
            }
        }
    }
}
