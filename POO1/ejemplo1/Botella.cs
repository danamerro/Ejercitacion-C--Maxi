using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        //CONSTRUCTOR
        public Botella(string color, string material) { 
            this.color = color;
            this.material = material;
        }
        private int capacidad;
        private string color;
        private string material;

        //SOLO DEVUELVO EL VALOR DE MATERIAL
        public string Material { 
            get { return material; }
        }

        //PROPIEDAD
        
        public int Capacidad {
            get { return capacidad; }
            set { capacidad = value; }
        }
        /*
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        */
    }
}
