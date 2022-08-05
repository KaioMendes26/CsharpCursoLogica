using System;
using System.Globalization;

namespace Programa
{

     class Program
    {

         static void Main(string[]args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double largura, altura, area, perimetro, diagonal;

            Console.Write("Base do retangulo: ");
            largura = double.Parse(Console.ReadLine(), CI);
            Console.Write("Altura do retangulo: ");
            altura = double.Parse(Console.ReadLine(), CI);

            area = largura * altura;
            perimetro = 2 * (largura + altura);
            diagonal = Math.Sqrt(Math.Pow(largura, 2.0) + Math.Pow(altura, 2.0));

            Console.Write("AREA = " + area.ToString ("F4", CI));
            Console.WriteLine();
            Console.Write("PERIMETRO = " + perimetro.ToString("F4", CI)) ;
            Console.WriteLine();
            Console.Write("DIAGONAL  = " + diagonal.ToString("F4", CI));









        }
    }
}