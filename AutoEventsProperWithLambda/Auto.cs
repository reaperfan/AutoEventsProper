using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEventsProperWithLambda
{
    class Auto
    {
        // public delegate void SebessegFigyeloMax(string uzenet);
        // public delegate void SebessegFigyeloKozelMax(string uzenet);

        //private SebessegFigyeloKozelMax figyeloKozelMax;
        //private SebessegFigyeloMax figyeloMax;
        public delegate void AutoEventHandler(object sender, AutoEventArgs e);

        public event AutoEventHandler figyeloKozelMax;
        public event AutoEventHandler figyeloMax;



        private static int MAX_SEB = 200;
        private static int KOZEL_MAX = 170;

        private int sebesseg;
        private string rendszam;

        public int MySebesseg
        {
            get { return sebesseg; }
            set { sebesseg = value; }
        }

        public string MyRendszam
        {
            get { return rendszam; }
            set { rendszam = value; }
        }
        public Auto(int sebesseg, string rendszam)
        {
            this.sebesseg = sebesseg;
            this.rendszam = rendszam;
        }
        public void Gyorsit(int seb)
        {
            this.MySebesseg += seb;
        }
        public override string ToString()
        {
            return "Rendszám : " + this.MyRendszam + " Sebesség : " + this.MySebesseg;
        }
        public void Ellenoriz()
        {
            if (this.MySebesseg >= KOZEL_MAX && this.MySebesseg <= MAX_SEB)
            {
                AutoEventArgs eventArgs = new AutoEventArgs("kozel a sebhat");
                figyeloKozelMax.Invoke(this,eventArgs);
            }
            if (this.MySebesseg >= MAX_SEB)
            {
                AutoEventArgs eventArgs = new AutoEventArgs("túl a sebhaton!");
                figyeloMax.Invoke(this, eventArgs);

            }
            
        }
     



    }
}
