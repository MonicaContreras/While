using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWhile3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar un programa que permita la carga de 10 valores 
             *por teclado y nos muestre posteriormente la suma de los valores 
             *ingresados y su promedio*/

            int valor,numero, contador=1, suma=0,promedio;
            


            Console.WriteLine("Programa suma y promedio");
            Console.WriteLine("Ingrese Valor: ");
            valor = int.Parse(Console.ReadLine());
                

            while (contador <= valor)
            {
                Console.WriteLine("Ingrese Numero: ");
                numero = int.Parse(Console.ReadLine());
                suma =suma+numero;
                contador++;

            }
            promedio = suma / valor;
            Console.WriteLine("La suma: " + suma+"\n");
            Console.WriteLine("El promedio: " + promedio);
            Console.ReadKey();
        }
    }
}
