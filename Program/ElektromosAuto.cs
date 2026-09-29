using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class ElektromosAuto : Jarmu
    {
        private int akkumulatorSzint;

        public ElektromosAuto(string rendszam, int kor, int kilometerOra, int akkumulatorSzint, int uzemanyagSzint) : base (rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            AkkumulatorSzint = akkumulatorSzint;
            uzemanyagSzint = 0;
        }

        public int AkkumulatorSzint { 
            get
            {
                return akkumulatorSzint;
            }
            set
            {
                if (value < 0)
                {
                    akkumulatorSzint = 0;
                }
                else if (value > 100)
                {
                    akkumulatorSzint = 100;
                }
                else
                {
                    akkumulatorSzint = value;
                }
            }
        }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves elektromos autó, {KilometerOra} km - rel, {AkkumulatorSzint} % töltöttséggel.");
        }

        public override void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
            }
            akkumulatorSzint += 20;
            Console.WriteLine("A jármű szervízelése megtörtént.");
        }
    }
}
