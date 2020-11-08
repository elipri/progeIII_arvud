using System;
using System.Collections.Generic;

namespace Esimene
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoi!");
            //1. Trükkida välja kõik kolmega jagunevad arvud vahemikus 1..100
            Console.WriteLine("Kõik arvud ühest sajani, mis jaguvad kolmega: ");
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //2.Lase kasutajal sisestada arve kuni tühi string vastuseks tuleb(ehk ENTER ilma midagi kirjutamata).Arvuta nende arvude summa ning min ja max väärtused. Trüki saadud tulemused ekraanile
            Console.WriteLine("\nLeian sinu poolt sisestatud arvude summa ning nende arvude min ja max väärtused. Lõpetamiseks jäta rida tühjaks ja vajuta ENTER.");
            Console.WriteLine("Palun sisesta arv ja vajuta ENTER: ");
            List<int> arvud = new List<int>();
            bool jookse = true;
            while(jookse)
            {
                string sisend = Console.ReadLine();
                if (string.IsNullOrEmpty(sisend))
                {
                    jookse = false;
                    break;
                }     
                arvud.Add(Int32.Parse(sisend));
            }
            if(!jookse && arvud.Count == 0)
            {
                Console.WriteLine("Lehv-lehv.");
            } else if (arvud.Count != 0)
            {
                int sum = 0;
                int min = arvud[0];
                int max = arvud[0];
                for (int i = 0; i < arvud.Count; i++)
                {
                    sum += arvud[i];
                    if (arvud[i] < min)
                        min = arvud[i];

                    if (arvud[i] > max)
                        max = arvud[i];

                }
                Console.WriteLine("Summa = " + sum);
                Console.WriteLine("Min = " + min);
                Console.WriteLine("Max = " + max);
                Console.WriteLine("Lehv-lehv.");
            } else
            {
                Console.WriteLine("Lehv-lehv.");
            }
        }
    }
}
