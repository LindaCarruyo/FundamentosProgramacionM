using System;
namespace _1.VariablesConstantesTiposDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores numericos
            //cambio de signo
            int dato1 = 5;
            int dato2 = -dato1;
            Console.Write(dato1 + "//" + dato2);
            //Aritmeticos 
            int dato3 = 5 + 6;
            int dato4 = 120 - 320;
            int dato5 = 12 * 23;
            float dato6 =  1113f / 333; // se puede castear un float [(float) 1113 / 333] antes de la operacion o colocar la f en uno de los dos numeros ( 5f / 3 , o 5 / 3f ) 
            Console.Write(" \n suma: {0} , resta: {1}, multplicacion: {2}, division: {3}", dato3, dato4, dato5, dato6);
            //incremento - decremento 
            dato3++;//dato3 = dato3 +1 
            Console.WriteLine("incremento: {0} ",dato3);
            dato4--;//decremento 
            Console.WriteLine("decremento: {0}", dato4);
            dato5 += 4;//dato5 = dato5 + 4 
            dato3 -= 5;// dato3 = dato3 - 5
            dato5 *= dato3;//dato5 = dato5 * dato3
            dato6 /= dato3;//dato6 = dato6/dato3
            // orden de evaluacion operadores numericos 
            float dato7 = 4 * 3 / 2;
            Console.WriteLine(dato7);
            float dato8 = 4.0f * (3.0f / 5.0f);
            Console.WriteLine(dato8);
            float dato9 = 4 + 5 * (2 - 1);
            Console.WriteLine(dato9);
            //Operadores logicos - conjuncion (Y) . disyncion(O)
            Console.WriteLine("Tabla de verdad de la conjuncion");
            Console.WriteLine("V Y V =" + (true && true));
            Console.WriteLine("V Y F =" + (true && false));
            Console.WriteLine("F Y V =" + (false && true));
            Console.WriteLine("F Y F=" + (false && false));
            Console.WriteLine("-------------------------------------");
           
            Console.WriteLine("Tabla de verdad de la disyuncion");
            Console.WriteLine("V O V =" + (true || true));
            Console.WriteLine("V O F =" + (true || false));
            Console.WriteLine("F O V =" + (false || true));
            Console.WriteLine("F O F=" + (false || false));
            Console.WriteLine("-------------------------------------");
            //Operadores de comparacion

            bool dato10 = 5 > 3;
            Console.WriteLine(dato10);
            bool dato11 = 3 < -5;
            Console.WriteLine(dato11);
            bool dato12 = 3 != 5;
            Console.WriteLine(dato12);
            bool dato13 = 3 <= 3;
            Console.WriteLine(dato13);
            bool dato14 = dato10 && dato11 || dato12;
            Console.WriteLine(dato14);

            // Completado

        }
    }
}
