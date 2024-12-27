using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpalapok_ketto

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  számtani sorozat tagjai  a sorozat elemeinek megjelenítése: a sorozat első eleme,  a differenciája  és az elemszáma ismeretében

            //Bekérjük a felhasználótól a sorozat első elemét:
            Console.Write("Kérlek add meg a sorozat első elemét: ");
            int elsoElem = int.Parse(Console.ReadLine()); //szöveg típus átalakítása
            //
            Console.Write("\nKérlek add meg a sorozat differenciáját: ");
            int differencia = int.Parse(Console.ReadLine());
            //számtani sorozat hosszának megadása(felhazsnáló dönti el)
            Console.Write("\nKérlek add meg a sorozat elemszámát: ");
            int elemSzam = int.Parse(Console.ReadLine());

            Console.WriteLine("A számtani sorozat elemei: ");
            //első elem kiiratása
            Console.WriteLine("\ta1={0}", elsoElem);
            //számtani sorozat létrehozása számláló ciklussal,a felhasználó által választott sorozathosszt a elemSzam-ba tároljuk el.
            for (int i = 2; i <= elemSzam; i++)
            {//több elem kiiratása
                Console.WriteLine("\ta{0}={1}", i, elsoElem + (i - 1) * differencia); //an=a1+(n-1)*d
            }

            Console.ReadKey();

        }
    }
}
