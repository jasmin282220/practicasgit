using System;

namespace prct2
{
    class Program
    {
        static void Main(string[] args)
        {
            float num, num1;
          float C = 0;
            float resultado;

            Console.WriteLine("introduzca un numero");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("el producto de 0 por cualquier numero es 0");


            if (num > C)
            {
                Console.WriteLine("en caso de  que no es 0 es multiplicable con cualquier otro numero");
            }
            else
            {
                if (num < C)
                    Console.WriteLine("el valor de 0 siempre sera 0");

                Console.WriteLine("introduzca otro numero");
                num1 = Convert.ToInt32(Console.ReadLine());
                resultado = Console.WriteLine("el resultado de los numeros es" + num * num1);


            }
        }

    }
}



 
