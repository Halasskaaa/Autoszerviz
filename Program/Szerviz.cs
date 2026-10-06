using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Szerviz
    {
        public List<Jarmu> Jarmuvek = new List<Jarmu>();

        public void JarmuFelvetele(Jarmu jarmu)
        {
            Jarmuvek.Add(jarmu);
            Console.WriteLine($"{jarmu.Rendszam} megérkezett a szervízbe.");
        }

        public void InformaciokListazasa()
        {
            foreach (Jarmu jarmu in Jarmuvek)
            {
                jarmu.InformaciotAd();
            }
        }

        public void CsoportosSzerviz(int dij)
        {
            foreach (Jarmu jarmu in Jarmuvek)
            {
                if (jarmu.SzervizSzukseges)
                {
                    jarmu.Szervizel(dij);
                }
                else
                {
                    Console.WriteLine($"A {jarmu.Rendszam} szervizelése jelenleg nem szükséges.");
                }
            }
        }
    }
}