using System;
using System.Diagnostics.Eventing.Reader;
using System.Timers;


namespace _5.CondicionalesAnidadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int A = 0;
            int B = 0;
            int C = 0;
            Console.WriteLine("Ingresar 3 valores diferntes");
            Console.WriteLine("Ingresar valor del numero A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar valor del numero B ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar valor del numero C");
            C = Convert.ToInt32(Console.ReadLine());*/
            /* if (A > B)
             {
                 if (A > C)
                 {
                     Console.WriteLine($" El numero {A} es el mayor");
                 }
                 else
                 {
                     Console.WriteLine($"El numero {C} es el mayor");
                 }
             }
             else
             {
                 if (B > C )
                 {
                     Console.WriteLine($"El numero {B} es el mayor");
                 }
                 else
                 {
                     Console.WriteLine($"El numero {C} es el mayor");
                 }
             }*/

            /*if (A<B && A>C)
            {
                Console.WriteLine($"El numero {A} es el mayor");
            }

            else
            {
                if (A<B && B>C)
                {
                    Console.WriteLine($"El numero mayor es {B}");
                }
                else
                {
                    if(C > A && C > B)
                    {
                        Console.WriteLine($"El numero {C} es el mayor");
                    }
                }
            }*/

            float C1 = 0f;
            float C2 = 0f;
            float C3 = 0f;
            float Prom = 0f;
            Console.WriteLine("Ingresar las calificaciones para sacar el promedio");
            Console.WriteLine("Ingresar la primera calificacion");
            C1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingresar la segunda calificacion");
            C2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingresar la tercera calificacion");
            C3 = Convert.ToSingle(Console.ReadLine());
            Prom = (C1 + C2 + C3) / 3;
            Console.WriteLine("eL promedio es:"+ Prom);
            
            if (Prom >= 9.5 && Prom <= 10.0)
            {
                Console.WriteLine("Excelente");
            }
            else
            {
                if (Prom >= 8.5 && Prom <= 9.4)
                {
                    Console.WriteLine("Muy bien");
                }
                else
                {
                    if (Prom >= 7.5 && Prom <= 8.4)
                    {
                        Console.WriteLine("Bien");
                    }
                }
            }
            if (Prom > 10.0 || Prom < 7.5)
            {
                Console.WriteLine("ERROR");
            }
           
        }           
    }
}
