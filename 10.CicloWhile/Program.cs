using System;

namespace _10.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Realizar un algoritmo que pida numeros enteros positivos y los sume, hasta que el usuario
                ingrese un numero negativo, en ese momento se mostrara el resultado de la suma. 
             */
            int numero = 0;
            int suma = 0;

            Console.WriteLine("Ingrese números enteros positivos. Para terminar, ingrese un número negativo.");

            do
            {
                Console.Write("Número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    suma += numero;
                }

            } while (numero >= 0);

            Console.WriteLine("La suma de los números ingresados es: " + suma);
        }


    }
}

