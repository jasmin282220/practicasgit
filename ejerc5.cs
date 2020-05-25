using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B, C_result;

            Console.WriteLine("ingrese el primer número");
            A = float.Parse(Console.ReadLine());

            if (A == 0)
            {
                Console.WriteLine("El producto de 0 por multiplicado por cualquier número es 0");
            }
            else
            {
                Console.WriteLine("ingrese el segundo numero");
                B = float.Parse(Console.ReadLine());

                C_result = A * B;
                Console.WriteLine("El resultado de la division es" + C_result);
            }
            Console.ReadKey();
            
        }
    }
}
