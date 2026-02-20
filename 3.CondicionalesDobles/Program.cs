using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CondicionalesDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // desatraso d  ejercicios 1 y 2 porfa

            /*    2. crear un algoritmo que permita ingresar dos numeros, si el primer número es mayor
              al segundo numero informar su suma y diferencia , en caso contrario informar el producto
              y la división del primer numero respecto al segundo numero    */

            float num1 =0;
            float num2 =0;

            Console.WriteLine(" Ingrese primer Numero");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese segundo Numero");
            num2 = float.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine(" el primer Numero " + num1 + " es mayor al segundo " + num2);
            }
            

        }
    }
}
