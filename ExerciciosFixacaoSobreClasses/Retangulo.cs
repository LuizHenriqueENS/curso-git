using System;
using System.Globalization;

namespace ExerciciosFixacaoSobreClasses
{
    class Retangulo
    {
        public double A;
        public double B;

        public double Area()
        {
            return A * B;
        }

        public double Perimetro()
        {
            return 2*(A + B);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
        }

        public override string ToString()
        {
            return "AREA: "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPERÍMETRO: "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDiagonal: "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
