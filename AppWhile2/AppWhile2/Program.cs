using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que solicite la carga de un valor positivo 
             *y nos muestre desde 1 hasta el valor ingresado de uno en uno.
             *Ejemplo: Si ingresamos 30 se debe mostrar en pantalla los números del 1 al 30*/

            int numero, contador=1;


            Console.WriteLine("programa valor ingresado");
            Console.WriteLine("Digite Valor: ");
            numero = int.Parse(Console.ReadLine());

            while (contador <= numero)
            {
                Console.WriteLine("numero: " + contador);
                contador++;

            }
            Console.ReadKey();


        }
    }
}
