using System;
using System.Globalization;

namespace ExerciciosFixacaoSobreClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
           
            Console.Write("ENTRE COM A LARGURA E A ALTURA DE UM RETANGULO \nLARGURA:");
            ret.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("ALTURA: ");
            ret.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double area = ret.Area();
            double perimetro = ret.Perimetro();
            double diagonal = ret.Diagonal();


            Console.WriteLine(ret);

        }
    }
}
