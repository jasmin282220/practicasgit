using System;

namespace jerc8
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B;

            Console.WriteLine("ingrese un numero");
            A = float.Parse(Console.ReadLine());

            Console.WriteLine("ingrese otro numero");
            B = float.Parse(Console.ReadLine());

            if ((A > 0) && (B > 0))
            {
                Console.WriteLine("Ambos números son positivos");
            }
            else if ((A < 0) && (B > 0))
            {
                Console.WriteLine("Uno de los números es positivo");
            }
            else if ((A > 0) && (B < 0))
            {
                Console.WriteLine("Uno de los números es positivo");
            }
            else
            {
                Console.WriteLine("Ninguno de los números es positivo");
            }
            Console.ReadKey();
        }
    }
}
