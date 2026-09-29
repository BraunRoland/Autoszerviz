using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {
        private string rendszam;
        private int kor;
        private int kilometerOra;
        private int uzemanyagSzint;
        private bool szervizSzukseges;

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            this.Rendszam = rendszam;
            this.Kor = kor;
            this.KilometerOra = kilometerOra;
            this.UzemanyagSzint = uzemanyagSzint;
            SzervizSzukseges = false;
        }

        public virtual void InformaciotAd()
        {
            Console.Write($"{Rendszam} - {Kor} éves autó, {KilometerOra} km-el");
        }

        public virtual void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
            }
                UzemanyagSzint -= 10;
                Console.WriteLine("A jármű szervízelése megtörtént");
        }

        public string Rendszam 
        {
            get => rendszam; 
            set 
            { 
                if (rendszam == "" || rendszam == null)
                {
                    rendszam = "ISMERETLEN";
                }
                else
                {
                    rendszam = value;
                }
            } 
        }
        public int Kor 
        { 
            get => kor;
            set
            {
                kor = Math.Clamp(value, 0, 50);
            }
        }
        public int KilometerOra 
        { 
            get => kilometerOra; 
            set
            {
                if (value <= 0)
                {
                    kilometerOra = 0;
                }
                else
                {
                    kilometerOra = value;
                }
            } 
        }
        public int UzemanyagSzint 
        { 
            get => uzemanyagSzint; 
            set
            {
                uzemanyagSzint = Math.Clamp(value, 0, 100);
            } 
        }
        public bool SzervizSzukseges         { 

            get => szervizSzukseges;
            set
            {
                if (KilometerOra >= 200000)
                {
                    szervizSzukseges = true;
                }
                else
                {
                    szervizSzukseges = false;
                }
               
            }
        }
    }
}
