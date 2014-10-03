using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNnumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que lea n números enteros y calcule la cantidad de valores mayores o iguales a 1000.*/

            int cont1, cont2 = 0, valor, num;

            Console.WriteLine("Calcule Numero mayores o iguales a 1000");

            Console.WriteLine("Ingrese la cantidad de numeros:  ");
            valor = int.Parse(Console.ReadLine());

            for (cont1 = 1; cont1 <=valor; cont1++)
            {
                Console.WriteLine("Digite el numero: ");
                num = int.Parse(Console.ReadLine());

                if (num >= 1000)
                {
                    cont2++;

                }


            }
            Console.WriteLine("los numeros mayores o iguales a 1000 son: " + cont2);

            Console.ReadKey();
        }
    }
}

