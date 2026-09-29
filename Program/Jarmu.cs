using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Program
{
    public class Jarmu
    {
        private string rendszam;
        private int kor;
        private int kilometerOra;
        private int uzemanyagSzint;

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            Rendszam = rendszam;
            Kor = kor;
            KilometerOra = kilometerOra;
            UzemanyagSzint = uzemanyagSzint;
        }

        public string Rendszam { 
            get
            {
                return rendszam;
            } 
            set {
                if (value == "" || string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("ISMERETLEN!");
                    rendszam = "ISMERETLEN";
                }
                else
                {
                    rendszam = value;
                }
            } 
        }

        public int Kor { 
            get
            {
                return kor;
            }
            set {
                if (value < 0)
                {
                    kor = 0;
                }
                else if (value > 50)
                {
                    kor = 50;
                }
                else
                {
                    kor = value;
                }
            } 
        }

        public int KilometerOra { 
            get 
            { 
                return kilometerOra;
            } 
            set
            {
                if (value < 0)
                {
                    kilometerOra = 0;
                }
                else
                {
                    kilometerOra = value;
                }
            }
        }
        public int UzemanyagSzint {
            get
            {
                return uzemanyagSzint;
            }
            set
            {
                if (value < 0)
                {
                    uzemanyagSzint = 0;
                }
                else if (value > 100)
                {
                    uzemanyagSzint = 100;
                }
                else
                {
                    uzemanyagSzint = value;
                }
            }
        }
        public bool SzervizSzukseges { 
            get 
            {
                return kilometerOra >= 200000;
            }  
        }

        public virtual void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves jármű, {KilometerOra} km-rel.");
        }

        public virtual void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                kilometerOra -= 10000;
            }
            UzemanyagSzint -= 10;
            Console.WriteLine("A jármű szervízelése megtörtént.");
        }
    }
}
