using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class TeherAuto : Jarmu
    {
        private int rakomany;
        public TeherAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int rakomany) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            this.Rakomany = rakomany;
        }
        public override void InformaciotAd()
        {
            base.InformaciotAd();
            Console.WriteLine($", rakomány: {Rakomany} tonna");
        }

        public override void Szervizel(int dij)
        {
            Rakomany = 0;
            base.Szervizel(dij);
        }

        public int Rakomany 
        { 
            get => rakomany; 
            set
            {
                if (rakomany < 0)
                {
                    rakomany = 0;
                }
                else if (rakomany > 20)
                {
                    rakomany = 20;
                }
                else
                {
                    rakomany = value;
                }
            } 
        }
    }
}
