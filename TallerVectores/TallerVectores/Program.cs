using System;

namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              1. Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego 
                 encuentre y muestre el valor máximo y mínimo de los números ingresados.  
           

            int[] NumerosEnteros = new int[15]; //cantidad de vectores a partir de cero

            Console.WriteLine("Asigna el valor a cada uno de los 15 vectores a continuación");

            for (int i = 0; i < NumerosEnteros.Length; i++) // pedir al usuario los numeros necesarios
            {
              Console.WriteLine($"Ingrese el vector #{ i + 1 }");
              NumerosEnteros[i] = int.Parse(Console.ReadLine());
              
            }
            */
            /*
             2. Escribir un algoritmo que permita: 
                a. Crear dos vectores del mismo tamaño.  
                b. Llenarlos con números.  
                c. Comparar posición por posición.  
                d. Indicar cuántos elementos son iguales. 
            */
            int[] Vector1 = new int[4];
            int[] Vector2 = new int[4];

            Console.WriteLine("ingrese los numerospara el primer vector: ");
            for (int i = 0; i < Vector1.Length; i++)
            {
                Console.WriteLine($"posición # { i }");
                Vector1[i] = int.Parse(Console.ReadLine());
          
            }
            Console.WriteLine("ingrese los numerospara el segundo vector: ");
            for (int i = 0; i < Vector2.Length; i++)
            {
                Console.WriteLine($"posición # {i}");
                Vector2[i] = int.Parse(Console.ReadLine());
           
            }
            

        }
    }
}

