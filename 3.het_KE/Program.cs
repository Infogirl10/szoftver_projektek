using System;

namespace csharpalapok_elso_resz
{
    class Program

    {
        static void Main(string[] args)
        {
            //Az első 100 természetes szám összegének meghatározása
           
            //Szükség van egy változóra, amiben eltároljuk a számok összegét
            int osszeg = 0;
            //egy ciklus segítségével összeadjuk az egymás után számokat. Ehhez szükség van egy i változóra, illetve a számlálós for ciklusra. 
            for (int i = 0; i <= 100; i++)
            {
                //A ciklusmag használjuk ehhez a osszeg változót amihez mindig hozzádjuk az i értékét.
                osszeg = osszeg+i;
               
                Console.WriteLine(osszeg+i);
            }
            //Összeg kiiratásához a Console.WriteLine-t kell használni, illetve az osszeg nevu változót.
            Console.WriteLine("Az első 100 természetes szám összege: {0}", osszeg);
            Console.ReadKey();


        }

    }
}

