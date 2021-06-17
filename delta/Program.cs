using System;
using System.Globalization;

namespace delta
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, delta, r1, r2;
            string[] valor = Console.ReadLine().Split(' ');

            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);
            //declare as demais variaveis


            delta = (Math.Pow(b, 2) - (4 * a * c));
            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2 * a);//declare a variavel corretamente

            if (a != 0 && delta > 0) // equacao do 2 grau a tem que ser diferente de zero
                                     // o valor de Δ for maior que zero (Δ > 0), a equação terá duas raízes reais e distintas.
            {

                Console.WriteLine("R1 = " + r1.ToString("F5"));

                Console.WriteLine("R2 = " + r2.ToString("F5"));

            }
            else
            {

                Console.WriteLine("Impossivel calcular");

            }




        }
    }
}
