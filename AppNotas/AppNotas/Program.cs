using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont1, cont2=0, cont3=0,valor=0;
            float nota;

            Console.WriteLine("Programa Notas");
            Console.WriteLine("Digite el Numero de Notas");
            valor = int.Parse(Console.ReadLine());
            for (cont1 = 1; cont1 <= valor; cont1++)
            {
                Console.WriteLine("Digite Nota: ");
                nota = float.Parse(Console.ReadLine());
                Console.WriteLine("la nota "   + cont1 + " es: "+nota);
                
                if (nota >= 3)
                {
                    cont2 = cont2 + 1;

                }
                else
                {
                    cont3 = cont3 + 1;

                }
            }
            Console.WriteLine("Digite Nota mayores de 3 son: "+cont2);
            Console.WriteLine("Digite Nota menores de 3 son: " + cont3);
            
Console.ReadKey();
        }
    }
}
