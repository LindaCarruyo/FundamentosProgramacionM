using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              1. Tiendas la Avenida desea desarrollar un  programa que permita ingresar
                 por teclado el monto de compra y el dia de la semana; para saber:
                 *Si el dia Martes o jueves, se realizará un descuento del 15%
                 *Si el dia lunes o miercoles, se realizará un descuento del 10%
                 *Si el dia viernes o sabado, se realizará un descuento del 20%
                 *Si es domingo no se realizará descuento
                 *Visualizar el dia, el descuento y el total de la compra 
            */
            /*
          char DiaSemana = ' ';
          float TotalCompra = 0;
          float Descuento = 0;

           Console.WriteLine(" Ingrese el dia de la semana L = Lunes ,M = Martes ,W = Miercoles , J = Jueves , V = Viernes, S = Sabado, D = Domingo");
           DiaSemana= char.Parse(Console.ReadLine());
           Console.WriteLine(" Ingresar valor de la compra");
           TotalCompra = float.Parse(Console.ReadLine());

           switch (DiaSemana)
           {
               case 'L':
                   Descuento = TotalCompra * 0.1f;
                   Console.WriteLine($"Hoy Lunes su descuento es de: {Descuento} y su total a pagar es de: {TotalCompra}");
                   break;
               case 'M':
                   Descuento = TotalCompra * 0.15f;
                   Console.WriteLine($"Hoy Martes su descuento es de: {Descuento} y su total a pagar es de: {TotalCompra}");
                   break;
               case 'W':
                   Descuento = TotalCompra * 0.1f;
                   Console.WriteLine($"Hoy Miercoles su descuento es de: {Descuento} y su total a pagar es de: {TotalCompra}");
                   break;
               case 'J':
                   Descuento = TotalCompra * 0.15f;
                   Console.WriteLine($"Hoy Jueves su descuento es de: {Descuento} y su total a pagar es de: {TotalCompra}");
                   break;
               case 'V':
                   Descuento = TotalCompra * 0.2f;
                   Console.WriteLine($"Hoy Viernes su descuento es de: {Descuento} y su total a pagar es de: {TotalCompra}");
                   break;
               case 'S':
                   Descuento = TotalCompra * 0.2f;
                   Console.WriteLine($"Hoy Sabado su descuento es de: {Descuento} y su total a pagar es de: {TotalCompra}");
                   break;
               case 'D':
                   Descuento = 0;
                   Console.WriteLine($"Hoy domingo no tenemos descuentos, su total a pagar es de: {TotalCompra}");
                   break;
               default:
                   Console.WriteLine("La letra ingresada NO corresponde a Un dia de la semana, asegurese de utilizar la letra correcta en mayuscula");
                   break;
                   */
            /*
               2. Diseñar un algoritmo que permita crear una calculadora basica capaz de realizar operaciones
                  aritméticas entre dos numeros ingresados por el usuario. Las operaciones disponibles serán:
                  Suma, Resta Multiplicación y División, las cuales se ejecutarán según la opción seleccionada 
                  por el usuario.
            */

            /*
           char TipoOperacion = ' ';
           float num1 = 0;
           float num2 = 0;
           float resul = 0;

           Console.WriteLine(" Ingrese que tipo de Operacion aritmetica quiere Realizar S= Suma ,R= Resta ,M= Multiplicación ,D= División ");
           TipoOperacion = char.Parse(Console.ReadLine());
           Console.WriteLine(" Ingrese primer numero");
           num1 = float.Parse(Console.ReadLine());
           Console.WriteLine(" Ingrese segundo numero");
           num2 = float.Parse(Console.ReadLine());

           switch (TipoOperacion)
           {
               case 'S':
                   resul = num1 + num2;
                   Console.WriteLine($"La suma: {num1} + {num2} = {resul}");
                   break;
               case 'R':
                   resul = num1 - num2;
                   Console.WriteLine($"La resta:{num1} - {num2} = {resul}");
                   break;
               case 'M':
                   resul = num1 * num2;
                   Console.WriteLine($"La división: {num1} * {num2} = {resul}");
                   break;
               case 'D':
                   resul = num1 / num2;
                   Console.WriteLine($"La multiplicación {num1} / {num2} = {resul}");
                   break;
               default:
                   Console.WriteLine("Opcion NO Valida");
                   break;

                   */
            /* 3. Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, de debe mostrar el siguiente mensaje; 
                  "Bienvenido a mi sitio web". De lo contrario, mostrar el mensaje "Usted no es apto para el contenidoi de este sitio web". 
            */

            Console.WriteLine(" Ingrese su edad ");




        }
    }
}
