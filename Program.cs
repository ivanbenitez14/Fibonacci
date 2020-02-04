using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indique la cantidad de numeros de Fibonacci que desea");
            String veces = Console.ReadLine();
            int nveces = Int16.Parse(veces);

            int x = 1, y = 0;
            int resultado;
            Console.Out.WriteLine(1);
            for (int contador = 0; contador < nveces; contador ++)
            {
                resultado = x + y;
                Console.Out.WriteLine(resultado);
                y = x;
                x = resultado;
            }
            Console.In.ReadLine();
        }
    }
}
