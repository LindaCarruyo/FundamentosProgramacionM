using System;

namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* //1. Escribir un algoritmo que permita generar primero 5 numeros enteros positivos y realizar y mostrar su suma. 
            
            int acumulador = 1; 
            int contador = 0 ;  // 0 porque se está sumando

            while (contador <= 5) ;
            {
                acumulador += contador;
                contador++;

                Console.WriteLine($"Contador: {contador} - Acumulador: {acumulador}");
            } 

            Console.WriteLine($"la suma de los cinco primeros numeros enteros es: {acumulador}");

            */

            // 2. Crear un algoritmo que permita calcular la factorial de un numero dado por el usuario ( 5! = 1 * 2 * 3 * 4 * 5 )

            int acumulador = 1;
            int contador = 1; //1 porque se está multiplicando
            int numero = 0;

            Console.WriteLine("Ingrese nuero para calcular su factorial");
            numero = Int32.Parse(Console.ReadLine());

            while (contador <= numero)
            {
                acumulador*=contador;
                contador++; 
            }
            Console.WriteLine($"La factorial del numero {numero} es: {acumulador}");
        }
      
    }
}
