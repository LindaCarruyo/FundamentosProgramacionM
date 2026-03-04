using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            1. Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1, 
               numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son 
               diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en 
               pantalla los números de menor a mayor.  
               Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben 
               ingresar números diferentes. 
            
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingrese el primer numero");
            num1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el primer segundo");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el primer Tercer Numero");
            num3 = int.Parse(Console.ReadLine());


            if (num1!=num2 && num1!=num3 && num2!=num3)
            {// Console.WriteLine("Números Diferentes");

        
                if (num1 < num2  &&  num2 < num3 && num1 < num3) ;
                {
                Console.WriteLine($"El orden de mayor a menor es: {num3}, {num2}, {num1}."); 
                }
                else 

                

            }
            else
            {
                Console.WriteLine("Hay números iguales");
            }

           /* 
            Otra form de hacerlo sería: Aunque es mucho mas tardado ya que se esá preguntando individualmente por cada numero...
            if (num1 == num2)
            {

                if (num2 == num3)
                {
                    Console.WriteLine("Los numeros no pueden ser iguales, Ingrese Numeros diferentes");
                }

            }
            else if (num1 > num2)
                if (num2 > num3)
                {
                    Console.WriteLine($"El orden de los numeros de mayor a menor es: {num1} , {num2} , {num3} ");
                }
                else if (num1 < num3)....etc... */


            /*
                2. El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si 
                cuenta con munición y si se encuentra en estado invencible, crear un programa que: 
                    a. Permita ingresar por teclado si el personaje está en estado invencible (True). 
                    b. La cantidad de munición que tiene el personaje en el momento será calculada por el 
                sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#. 
                    Ejemplo:  
                    int numero; 
                    Random rnd = new Random(); 
                    numero = rnd.Next(1, 6);//Devuelve un número entre 0 y 5 
                    Console.WriteLine(numero); 
             */
            

        }
    }
}
