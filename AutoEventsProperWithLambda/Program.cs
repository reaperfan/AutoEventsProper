using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoEventsProperWithLambda

{
    class Program
    {

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }
        void Run()
        {
            Auto a = new Auto(50, "ABC-123");
            Auto b = new Auto(90, "CBA-321");

            a.figyeloKozelMax += delegate (object sender, AutoEventArgs e)
            {
                Console.WriteLine("Küldő: " + sender.ToString() + " Üzenet" + e.MyUzenet);
            };
            a.figyeloMax += delegate (object sender, AutoEventArgs e)
            {
                Console.WriteLine("Küldő: " + sender.ToString() + " Üzenet" + e.MyUzenet);
            };

            b.figyeloKozelMax += delegate (object sender, AutoEventArgs e)
            {
               Console.WriteLine("Küldő: " + sender.ToString() + " Üzenet" + e.MyUzenet);
            };
            b.figyeloMax += delegate (object sender, AutoEventArgs e)
            {
                Console.WriteLine("Küldő: " + sender.ToString() + " Üzenet" + e.MyUzenet);
            };


            for (int i = 0; i < 10; i++)
            {
                
                a.Ellenoriz();
                //Console.WriteLine(a.ToString());
                a.Gyorsit(20);
                Console.WriteLine("-------------------");


                b.Ellenoriz();
                //Console.WriteLine(b.ToString());
                b.Gyorsit(20);
                Console.WriteLine("-------------------");
                Thread.Sleep(500);
            }
            

            //Console.WriteLine(a.ToString());
            //Console.WriteLine(b.ToString());
            Console.ReadKey();
        }

 
    }
    
}
