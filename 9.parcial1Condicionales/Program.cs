using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.parcial1Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                1.Desarrollar un programa en C# que permita a un usuario seleccionar una sala de juegos y un juego según su edad, y calcular el precio a pagar. (70%)
                Requerimientos del programa : ver en documento de word o correo
            */
            int edad = 0;
            int juego1=3000, juego2 =2000, juego3=7000,juego4 = 9000,juego5=7000, juego6 = 9000, juego7 = 10000, juego8 = 7000, juego9 = 5000, juego10 = 3000;
            int seleccionSala = 0;
            int seleccionJuego = 0;

            Console.WriteLine("Ingrese edad del usuario: ");
            edad = int.Parse(Console.ReadLine());

            if (edad <=5 && edad >1 ) 
            {
              Console.WriteLine($"El usuario puede entrar a la sala 1 y seleccionar los juegos: 1)Juego1 5) juego5 ");
                seleccionJuego = int.Parse(Console.ReadLine());
                if (seleccionJuego == 1)
                {
                    Console.WriteLine($"el precio a pagar es de: {juego1}");
                }
                else if (seleccionJuego == 5)
                {
                    Console.WriteLine($"el precio a pagar es de: {juego5}");
                }
                else
                {
                    Console.WriteLine("Error, juego no valido");
                }
       
            }
            else if (edad >6 && edad <=16)
            {
                Console.WriteLine("El usuario puede entrar a la sala 2 y seleccionar los juegos: a)Juego3 b)juego6 ");
                seleccionJuego = int.Parse(Console.ReadLine());
                if (seleccionJuego == 3)
                {
                    Console.WriteLine($"el precio a pagar es de: {juego3}");
                }
                else if (seleccionJuego == 6)
                {
                    Console.WriteLine($"el precio a pagar es de: {juego6}");
                }
                else
                {
                    Console.WriteLine("Error, juego no valido");
                }
            }
            else if (edad >17 && edad <= 25)
            {

                Console.WriteLine("el usuario puedee seleccionar las siguientes salas: sala3: 3 y sala4: 4");
                seleccionSala = int.Parse(Console.ReadLine());

                if (seleccionSala == 3)
                {
                    Console.WriteLine("el usuario puede seleccionar los juegos: 2) juego2 y 8) juego8");
                    seleccionJuego = int.Parse(Console.ReadLine());
                    if (seleccionJuego == 2)
                    {
                        Console.WriteLine($"el precio a pagar es de: {juego2}");
                    }
                    else if (seleccionJuego == 8)
                    {
                        Console.WriteLine($"el precio a pagar es de: {juego8}");
                    }
                    else
                    {
                        Console.WriteLine("Error, juego no valido");
                    }

                }
                else if (seleccionSala == 4)
                {
                    Console.WriteLine("el usuario puede seleccionar los juegos: 4) juego4 y 7) juego7");
                    seleccionJuego = int.Parse(Console.ReadLine());
                    if (seleccionJuego == 4)
                    {
                        Console.WriteLine($"el precio a pagar es de: {juego4}");
                    }
                    else if (seleccionJuego == 7)
                    {
                        Console.WriteLine($"el precio a pagar es de: {juego7}");
                    }
                    else
                    {
                        Console.WriteLine("Error, juego no valido");
                    }
                }
                else
                {
                    Console.WriteLine("Error, sala no valida");
                }

              
            }
            else if (edad > 25)
            {
                Console.WriteLine("el usuario puede entrara a ,a sala 5 y seleccionar: 9) juegos9 y 0) juego10");
                seleccionJuego = int.Parse(Console.ReadLine());
                if (seleccionJuego == 9)
                {
                    Console.WriteLine($"el precio a pagar es de: {juego9}");
                }
                else if (seleccionJuego == 0)
                {
                    Console.WriteLine($"el precio a pagar es de: {juego10}");
                }
                else               
                {
                    Console.WriteLine("Error, juego no valido");
                }
            }
            else
            {
                Console.WriteLine("Error, edad no valida");
            }

            Console.WriteLine($"edad del usuario: {edad} ");
            Console.WriteLine($"Sala seleccionada: {seleccionSala} ");
            Console.WriteLine($"Juego seleccionado: {seleccionJuego} ");
            


        }
    }
}
