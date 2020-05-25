using System;

namespace prct3
{
    class Program
    {
        static void Main(string[] args)
        {
           double numero, numero2;

            Console.WriteLine("ingrese un numero");
            numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese otro numero");
            numero2 = Convert.ToDouble(Console.ReadLine());


            if (numero % numero2 == 0)
            {
                Console.WriteLine("el primer numero es multiplo del segundo numero");
            }
            else
                Console.WriteLine("el primer numero no es multiplo del segundo");

            }
        }

    }
