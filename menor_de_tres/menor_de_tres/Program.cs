using System;
using System.Globalization;

namespace Programa
{
   class Program
    {

        static void Main(String[] argr)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int a, b, c, menor;

            Console.Write("Primeiro velor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Terceiro valor:");
            c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                menor = a;
            }
            else if (b < a && b < c)
            {
                menor = b;

            }
            else
            {
                menor = c;
            }

            Console.WriteLine("MENOR = " + menor);








        }
    }
}
