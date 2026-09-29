using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class ElektromosAuto : Jarmu
    {
        private int akkumulatorSzint;
        public ElektromosAuto(string rendszam, int kor, int kilometerOra, int akkumulatorSzint) : base(rendszam, kor, kilometerOra, 0)
        {
            this.AkkumulatorSzint = akkumulatorSzint;
        }
        public override void InformaciotAd()
        {
            base.InformaciotAd();
            Console.WriteLine($", {AkkumulatorSzint}% töltöttséggel.");
        }
        public override void Szervizel(int dij)
        {
            if (dij > 100000)
            {
               KilometerOra -= 10000;
            }
                AkkumulatorSzint += 20;
                Console.WriteLine("A jármű szervízelése megtörtént");
        }

        public int AkkumulatorSzint 
        { 
            get => akkumulatorSzint;
            set
            {
                this.akkumulatorSzint = Math.Clamp(value, 0, 100);
            }
        }

    }
}
