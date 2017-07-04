using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UriOnlineJudge
{
    class Program
    {
        static void Main(string[] args)
        {
            int restoCem = 0, restoCinquenta = 0, restoVinte =0, restoDez=0, restoCinco=0, restoDois=0;
            int restoUm=0, RestoCinqCentavos=0, RestoVinCinCentavos=0, RestoDezCent=0, RestoCinCent=0, RestoUmCent=0;
            double Nota = Double.Parse(System.Console.ReadLine().Trim());

            int i = 1;

            if(0 <= Nota && Nota <= 1000000.00)
            {
                while (i != 0 )
                {

                    if (Nota >= 100)
                    {
                        restoCem = restoCem + 1;
                        Nota = Nota - 100;

                    }
                    else if (Nota >= 50)
                    {
                        restoCinquenta = restoCinquenta + 1;
                        Nota = Nota - 50;
                    }
                    else if (Nota >= 20)
                    {
                        restoVinte = restoVinte + 1;
                        Nota = Nota - 20;
                    }
                    else if (Nota >= 10)
                    {
                        restoDez = restoDez + 1;
                        Nota = Nota - 10;
                    }
                    else if (Nota >= 5)
                    {
                        restoCinco = restoCinco + 1;
                        Nota = Nota - 5;
                    }
                    else if (Nota >= 2)
                    {
                        restoDois = restoDois + 1;
                        Nota = Nota - 2;
                    }
                    else if (Nota >= 1)
                    {
                        restoUm = restoUm + 1;
                        Nota = Nota - 1;
                    }
                    else if (Nota >= 0.50)
                    {
                        RestoCinqCentavos = RestoCinqCentavos + 1;
                        Nota = Nota - 0.50;
                    }
                    else if (Nota >= 0.25)
                    {
                        RestoVinCinCentavos = RestoVinCinCentavos + 1;
                        Nota = Nota - 0.25;
                    }
                    else if (Nota >= 0.10)
                    {
                        RestoDezCent = RestoDezCent + 1;
                        Nota = Nota - 0.10;
                    }
                    else if (Nota >= 0.05)
                    {
                        RestoCinCent = RestoCinCent + 1;
                        Nota = Nota - 0.05;
                    }
                    else if (Nota >= 0.01)
                    {
                        RestoUmCent = RestoUmCent + 1;
                        Nota = Nota - 0.01;
                    }
                    else if (Nota < 0.01)
                        i = 0;
                    
                } 

                Console.Write("NOTAS:\n");
                Console.Write("{0} nota(s) de 100.00\n", restoCem);
                Console.Write("{0} nota(s) de 50.00\n", restoCinquenta);
                Console.Write("{0} nota(s) de 20.00\n", restoVinte);
                Console.Write("{0} nota(s) de 10.00\n", restoDez);
                Console.Write("{0} nota(s) de 5.00\n", restoCinco);
                Console.Write("{0} nota(s) de 2.00\n", restoDois);
                Console.Write("MOEDAS:\n");
                Console.Write("{0} moeda(s) de 1.00\n", restoUm);
                Console.Write("{0} moeda(s) de 0.50\n", RestoCinqCentavos);
                Console.Write("{0} moeda(s) de 0.25\n", RestoVinCinCentavos);
                Console.Write("{0} moeda(s) de 0.10\n", RestoDezCent);
                Console.Write("{0} moeda(s) de 0.05\n", RestoCinCent);
                Console.Write("{0} moeda(s) de 0.01\n", RestoUmCent);
               

            }
        }
    }
}
