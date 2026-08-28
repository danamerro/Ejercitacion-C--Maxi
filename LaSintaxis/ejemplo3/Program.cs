using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ciclos
            //for, while, do while, for each

            int a = 10;

            for (int x = 0; x < 10; x++) { 
                while (a != 0){
                    Console.WriteLine("Hola " + x);
                    a--;
                }                
            }
            Console.ReadKey();
        }
    }
}
