using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class ExtraJarmu : Jarmu
    {
        private int bioUzemanyagSzint;
        private int karcolasok;

        public ExtraJarmu(string rendszam, int kor, int kilometerOra, int bioUzemanyagSzint, int karcolasok) : base(rendszam, kor, kilometerOra, 0)
        {
            BioUzemanyagSzint = bioUzemanyagSzint;
            Karcolasok = karcolasok;
        }

        public int BioUzemanyagSzint
        {
            get
            {
                return bioUzemanyagSzint;
            }
            set
            {
                if (value < 0)
                {
                    bioUzemanyagSzint = 0;
                }
                else if (value > 100)
                {
                    bioUzemanyagSzint = 100;
                }
                else
                {
                    bioUzemanyagSzint = value;
                }
            }
        }
        public int Karcolasok
        {
            get
            {
                return karcolasok;
            }
            set
            {
                if (value < 0)
                {
                    karcolasok = 0;
                }
                else if (value > 30)
                {
                    karcolasok = 30;
                }
                else
                {
                    karcolasok = value;
                }
            }
        }
        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves extra jármű, {KilometerOra} km - rel, {BioUzemanyagSzint} % bio üzemanyaggal.");
        }

        public override void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
            }
            bioUzemanyagSzint += 20;
            karcolasok -= 10;
            Console.WriteLine("A jármű szervízelése megtörtént.");
        }

    }
}
