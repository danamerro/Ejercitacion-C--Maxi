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
            /*
            Persona p1 = new Persona("Pepe");
            p1.setEdad(20);
            Console.WriteLine(p1.saludar());
            Console.WriteLine(p1.saludar("DANA"));
            Console.WriteLine("La edad de la persona es: " + p1.getEdad());
            */

            /*
            Perro p1 = new Perro();
            p1.Raza = "Pitbull"; p1.Color = "Marron"; p1.Edad = 1; p1.Nombre = "Pickles";

            Console.WriteLine("La mascota es un " + p1.Raza + " tiene " + p1.Edad + " años " + " y se llama " + p1.Nombre);

            */

            /* Primer lote de 10 registros de productos, cada producto tiene:
             * - Codigo Articulo (3 digitos no correlativos)
             * - Precio
             * - Codigo de marca
             * 
             * Segundo lote con las ventas de la semana. Cada venta tiene:
             * - Codigo Articulo
             * - Cantidad
             * - Código Cliente
             * Este lote corta con Codigo de Cliente cero. 
             */
            /*
            Articulo[] articulos = new Articulo[10];

            for (int x = 0; x < 10; x++) { 
                Console.WriteLine("Ingrese los datos del producto..");
                Console.WriteLine("Código:");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio:");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 al 10)");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            }

            //cargado el vector completo con los 10
            Venta venta = new Venta();
            Console.WriteLine("Codigo del cliente:");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0) {
                Console.WriteLine("Ingrese la venta:");
                Console.WriteLine("Codigo Artículo:");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad:");
                venta.Cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Codigo del cliente:");
                venta.CodigoCliente = int.Parse(Console.ReadLine());

                //trabajamos....

                //pido cliente nuevamente:
                Console.WriteLine("Ingrese la venta:");
                Console.WriteLine("Codigo Artículo:");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());

            }

            
            */

            Botella b1 = new Botella("Rojo","Plastico");

            //b1.Capacidad = 200;

            //Botella b2 = new Botella();
            
            Console.WriteLine("Capacidad Botella: " +  b1.Capacidad);
            Console.WriteLine("La cantidad actual es: " + b1.CantidadActual);

            b1.recargar(20);
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.CantidadActual);


            b1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.CantidadActual);
            
            //int algo = b1.Capacidad;

            //Console.WriteLine("La capacidad de la botella es: " + b1.Capacidad);

            //float valor = 1.233333F;
            //Console.WriteLine(valor.ToString());

            Console.ReadKey();


        }
    }
}
