using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.het_KE_4
{
    internal class Program
    { //Négyzetszámok kiírása 0-tól 200-ig
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("A 200-nál kisebb négyzetszámok: ");
            //i- addig amíg 0-nél nagyobb.
            while (i <= 200)
            {
                //{0}:pl 3, {1}:9(3 négyzete)
                Console.WriteLine("\t{0}^2={1}", i, (i * i));
                i++;
            }
            Console.ReadKey();
        }
    }
}
