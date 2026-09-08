using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;

            //Console.WriteLine("La fecha es: " + fecha.AddDays(5));
            Console.WriteLine("La fecha es: " + fecha.ToShortDateString());

            Console.ReadKey();

        }
    }
}
