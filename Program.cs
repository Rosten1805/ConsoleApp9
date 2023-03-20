using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el lado 1: ");
            int lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 2: ");
            int lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 3: ");
            int lado3 = int.Parse(Console.ReadLine());

            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else
            {
                Console.WriteLine("El triángulo no es equilátero.");

                if (lado1 > lado2 && lado1 > lado3)
                {
                    Console.WriteLine("El lado más largo es el lado 1.");
                }
                else if (lado2 > lado1 && lado2 > lado3)
                {
                    Console.WriteLine("El lado más largo es el lado 2.");
                }
                else
                {
                    Console.WriteLine("El lado más largo es el lado 3.");
                }
            }
            Console.ReadKey();
        }
    }
}