using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             variables
             int float, bool, char
             double, decimal, long, short, string, datatime
             
             */
            Console.WriteLine("Hola Mundo");
            Console.WriteLine("Ingrese un nro: ");
            int a, b, c;
            float d, f;

            a = int.Parse(Console.ReadLine());
            b = 10;
            c = a + b;

            Console.WriteLine("EL resultado es: " + c);
            Console.ReadKey();

        }
    }
}
