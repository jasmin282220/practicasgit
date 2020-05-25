using System;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //progarama que acepte tres numeros y diga cual es el mayor
            double numero, numero2, numero3;

            Console.WriteLine("ingrese el primer numero");
            numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese el tercer numero");
            numero3 = Convert.ToDouble(Console.ReadLine());


            if ((numero > numero2) && (numero2 > numero3))
            {
                Console.WriteLine("el numero mayor es.Numero= " + numero);

            }
            else if ((numero < numero2) && (numero2 > numero3))
            {
                Console.WriteLine("El numero mayor es.Numero= " + numero2);
            }
            else
            {
                Console.WriteLine("El numero mayor es.Numero= " + numero3);
            }
            Console.ReadKey();
        }
    }
}