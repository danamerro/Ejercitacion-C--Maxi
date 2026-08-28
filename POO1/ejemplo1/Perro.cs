using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Perro
    {
        private string raza;
        private string color;
        private int edad;
        private string nombre;

        public string Raza { 
            get { return raza; }
            set { raza = value; }
        }

        public string Color { 
            get { return color; }
            set { color = value; }
        }

        public int Edad { 
            get { return edad; }
            set { edad = value; }
        }

        public string Nombre { 
            get { return nombre; }
            set{ nombre = value; }
        }   
    }
}
