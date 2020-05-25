using System;

namespace prct2
{
    class Program
    {
        static void Main(string[] args)
        {
           double a,b;
            double resultado;

           
            

            Console.WriteLine("introduzca un numero");
           a = float.Parse(Console.ReadLine());
            Console.WriteLine("introduzca otro numero");
            b = float.Parse(Console.ReadLine());

            if (b == 0)
            {
                Console.WriteLine("ERROR no se puede dividir entre 0");
            }
            else
            {
                resultado = a / b;
                Console.WriteLine("el resultado de la division es" + resultado);

                Console.ReadKey();






            }
        }

    }
}