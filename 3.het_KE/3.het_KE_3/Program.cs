using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.het_KE_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Átlagszámítás
            int szam = 1;
            int db = 0;
            int osszeg = 0;
            Console.WriteLine("A számításhoz meg kell adni a végén a 0-t.");
            //Addig kérjük be számokat amíg nem 0-t adunk meg
            while (szam != 0)
            {
               
                Console.Write("Adj meg egy számot: ");
                szam = int.Parse(Console.ReadLine());
                db++;
                if (szam == 0)
                {
                   
                }
                osszeg = osszeg+szam;
            }
            //Átlagszámítás: bekért számok összege osztva a bekért számok darabszámával.
            double atlag = osszeg / db;
            Console.WriteLine("A számok átlaga: {0}", atlag);

            Console.ReadKey();

        }


    }
}

