using System;

namespace ejrc7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;

            Console.WriteLine("ingrese un numero");
            A = Convert.ToInt32(Console.ReadLine());

            if (A % 4 == 0)
            {
                Console.WriteLine("El numero ingresado es multiplo de 4");
            }
            else if (A % 5 == 0)
            {
                Console.WriteLine("El numero ingresado es multiplo de 5");
            }  else
            {
                Console.WriteLine("El número no es múltiplo ni 4 ni de 5");
            }
        }
    }
}