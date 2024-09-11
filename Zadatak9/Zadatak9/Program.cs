using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj članova niza: ");
            int brojClanova = int.Parse(Console.ReadLine());

            if (brojClanova <= 0)
            {
                Console.WriteLine("Broj članova mora biti veći od 0.");
                return;
            }

            int[] niz = new int[brojClanova];

            for (int i = 0; i < brojClanova; i++)
            {
                Console.Write($"Unesite vrijednost za član {i + 1}: ");
                niz[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(niz);

            Console.WriteLine("Sortirani niz: ");
            foreach (int broj in niz)
            {
                Console.Write(broj + " ");
            }

            Console.ReadKey();
        }
    }
}
