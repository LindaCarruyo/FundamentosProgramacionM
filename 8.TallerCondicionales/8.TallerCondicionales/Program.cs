using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

        
                if (num1 < num2  &&  num2 < num3 && num1 < num3) 
                {
                Console.WriteLine($"El orden de mayor a menor es: {num3}, {num2}, {num1}.");
                }
                else if (num1 < num2 && num1 < num3 && num2 > num3)
                {
                    Console.WriteLine($"El orden de mayor a menor es: {num2}, {num3}, {num1}.");
                }
                else if (num2 < num1 && num2 < num3 && num1 > num3)
                {
                    Console.WriteLine($"El orden de mayor a menor es: {num1}, {num3}, {num2}.");
                }
                else if (num2 < num1 && num2 < num3 && num1 < num3)
                {
                    Console.WriteLine($"El orden de mayor a menor es: {num3}, {num1}, {num2}.");
                }
                else if (num3 < num1 && num3 < num2 && num1 > num2)
                {
                    Console.WriteLine($"El orden de mayor a menor es: {num1}, {num2}, {num3}.");
                }
                else if (num3 < num1 && num3 < num2 && num1 < num2)
                {
                    Console.WriteLine($"El orden de mayor a menor es: {num2}, {num1}, {num3}.");
                }

            }
            else
            {
                Console.WriteLine("Hay números iguales, por favor ingrese numeros diferentes");
                //añadir volver a pedir 3 numeros hasta que sean diferentes, para esto se puede usar un ciclo while o do while, pero no se ha visto en clase aun, por eso no lo añadi
            }
            */
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
                 else if (num1 < num3)....etc... 


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
                    c.Si el estado del personaje es invencible (true) y su cantidad de munición está entre 1 y
                      10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario
                      no hacer nada.
              */

            /*
            3. Crear un algoritmo que permita ingresar las coordenadas x,y, para tres puntos: P1(x1,y1),
                P2(x2,y2), P3(x3,y3). Luego calcular la distancia entre los puntos P1  P2, P2  P3, P1
                P3. La distancia entre dos puntos está dada por la siguiente formula:
                d = √((x2 - x1)² + (y2 - y1)²)
                Después de haber calculado la distancia entre los puntos, el algoritmo debe decir si con
                dichas distancias se puede construir un triángulo, consultar las condiciones que se deben
                cumplir para realizar dicha construcción. En caso contrario, decir cuál o cuáles de las
                condiciones no se cumplen.  
                la suma de las longitudes de dos de sus lados debe ser mayor que la longitud del tercer lado (
                ). Además, la suma de los tres ángulos interiores siempre debe ser igual a 
            
             

            int x1, y1, x2, y2, x3, y3 = 0;
            int distanciaP1P2 = 


            Console.WriteLine("Ingrese la coordenada x del punto 1");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y del punto 1");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada x del punto 2");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y del punto 2");
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada x del punto 3");
            x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y del punto 3");
            y3 = int.Parse(Console.ReadLine());
*/


            /* 
             4.El personaje de un juego, solo se puede mover en forma horizontal(Izquierda o Derecha),
               crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve
               hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado.
                Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la
               derecha
                Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la derecha
                En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra
               dirección”
            
            char izquerda = 'i';
            char derecha = 'd';
            char salto = 's';    //Incluí estas opciones para que el personaje pueda saltar o agacharse, aunque no se pidieron en el ejercicio, pero me pareció divertido añadirlas
            char agacharse = 'a';

            Console.WriteLine("Presione la tecla 'd' para moverse a la derecha, 'i' para moverse a la izquierda, 's' para saltar y 'a' para agacharse");

            if (Console.ReadKey().KeyChar == derecha)
            {
                Console.WriteLine("El personaje se mueve hacia la derecha");
            }
            else if (Console.ReadKey().KeyChar == izquerda)
            {
                Console.WriteLine("El personaje se mueve hacia la izquierda");
            }
            else if (Console.ReadKey().KeyChar == salto)
            {
                Console.WriteLine("El personaje salta");
            }
            else if (Console.ReadKey().KeyChar == agacharse)
            {
                Console.WriteLine("El personaje se agacha");
            }
            else
            {
                Console.WriteLine("No me puedo mover en otra dirección");
            }

            */

            /*
             5. El personaje de un juego, puede realizar diferentes acciones dependiendo del carácter que
                el usuario ingrese, y de la cantidad de vidas que posee. Crear un programa que permita:
                 Generar un número aleatorio entre 0 y 5 para simular el número de vidas del personaje.
                (Función Random)
                 Si el número de vidas es mayor a 0, el personaje puede realizar acciones en el juego. En
                caso contrario escribir el mensaje “el personaje no posee vidas, y no puede realizar
                ninguna acción”. 
                 Si el personaje puede realizar acciones, escribir los siguientes mensajes de acuerdo al
                carácter que se ingrese:
                o Si se ingresa ‘c’, mostrar en consola “el personaje está disparando”
                o Si se ingresa ‘x’, mostrar en consola “el personaje está hablando con la Rana”
                o Si se ingresa ‘t’, mostrar en consola “el personaje está en modo Turbo”
                o Si se presiona ‘i’, mostrar en consola “el personaje es Invencible”
             */
            
            char disparar = 'c';
            char hablar = 'x';
            char turbo = 't';
            char invencible = 'i';
            sbyte vidas = 0;
            
            //vidas = Random.Next(0,6); //Genera un número aleatorio entre 0 y 5 para simular el número de vidas del personaje pero no me dió
            Console.WriteLine("Ingrese el número de vidas del personaje (entre 0 y 5)"); 
            vidas = sbyte.Parse(Console.ReadLine());

            if (vidas == 0)
            {
                Console.WriteLine("El personaje no posee vidas, y no puede realizar ninguna acción");
            }
            else if (vidas < 0 || vidas > 5)
            {
                Console.WriteLine("Número de vidas inválido, por favor ingrese un número entre 0 y 5");
            } // temporal ya que no se utilizar elr andom, pero se puede añadir un ciclo while para que siga pidiendo el número de vidas hasta que sea válido, pero no se ha visto en clase aun, por eso no lo añadí 
            else 
            {
                Console.WriteLine("El personaje tiene " + vidas + " vidas, y puede realizar las siguientes acciones en el juego: disparar (c), hablar con la Rana (x), modo Turbo (t) e Invencible (i). Ingrese la acción que desea realizar:");

                if (Console.ReadKey().KeyChar == disparar)
                {
                    Console.WriteLine("El personaje está disparando");
                }
                else if (Console.ReadKey().KeyChar == hablar)
                {
                    Console.WriteLine("El personaje está hablando con la Rana");
                }
                else if (Console.ReadKey().KeyChar == turbo)
                {
                    Console.WriteLine("El personaje está en modo Turbo");
                }
                else if (Console.ReadKey().KeyChar == invencible)
                {
                    Console.WriteLine("El personaje es Invencible");
                }
              

            }


        }
    }
}
