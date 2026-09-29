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
        private bool szervizSzukseges
;
        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            this.Rendszam = rendszam;
            this.Kor = kor;
            this.KilometerOra = kilometerOra;
            this.UzemanyagSzint = uzemanyagSzint;
        }

        public virtual void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves autó, {KilometerOra} km-el");
        }

        public virtual void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
                UzemanyagSzint -= 10;
                Console.WriteLine("A jármű szervízelése megtörtént");
            }
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
                if (kor < 0)
                {
                    kor = 0;
                }
                else if (kor > 50 )
                {
                    kor = 50;
                }
                else
                {
                    kor = value;
                }
            }
        }
        public int KilometerOra 
        { 
            get => kilometerOra; 
            set
            {
                if ( kilometerOra < 0)
                {
                    kilometerOra = 0;
                }
            } 
        }
        public int UzemanyagSzint 
        { 
            get => uzemanyagSzint; 
            set
            {
                if ( uzemanyagSzint < 0)
                {
                    uzemanyagSzint = 0;
                }
                else if ( uzemanyagSzint > 100 )
                {
                    uzemanyagSzint = 100;
                }
                else
                {
                    uzemanyagSzint = value;
                }
            } 
        }
        public bool SzervizSzukseges 
        { 
            get => szervizSzukseges; 
            set
            {
                if (uzemanyagSzint >= 200000)
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
