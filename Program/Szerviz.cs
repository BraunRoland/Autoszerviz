using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Szerviz
    {
        private List<Jarmu> jarmuvek;

        public Szerviz(List<Jarmu> jarmuvek)
        {
            this.jarmuvek = jarmuvek;
        }

        public void JarmuFeltetele(Jarmu jarmu)
        {
            jarmuvek.Add(jarmu);
            Console.WriteLine("A jármű megérkezett a szervízbe");
        }

        public void InformaciokListazasa()
        {
            foreach (var j in jarmuvek)
            {
                j.InformaciotAd();
            }
        }

        public void CsoportosSzerviz(int dij)
        {
            foreach (var j in jarmuvek)
            {
                if(j.SzervizSzukseges)
                {
                    j.Szervizel(dij);
                }
                else
                {
                    Console.WriteLine($"{j.Rendszam} szervízelése nem szükséges");
                }
            }
        }

        public List<Jarmu> Jarmuvek { get => jarmuvek; set => jarmuvek = value; }
    }
}
