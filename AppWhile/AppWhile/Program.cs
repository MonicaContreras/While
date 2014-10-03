using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int piezas, contador=0;
            float longitud;

            Console.WriteLine("Programa fabrica de perfiles");
            Console.WriteLine("Lea Numero de Piezas: ");
            piezas=int.Parse(Console.ReadLine());

                       while (contador < piezas)
            {
                Console.WriteLine("Lea La Longitud: ");
                longitud = float.Parse(Console.ReadLine());

                if (longitud >= 1.20 && longitud <= 1.30)
                {
                    Console.WriteLine("la pieza  " + longitud + "Es apta");

                }
                else
                {
                    Console.WriteLine("la pieza  " + longitud + "No es apta");
                   

                }
                contador++;
            }
                       Console.ReadKey(); 

        }
    }
}
