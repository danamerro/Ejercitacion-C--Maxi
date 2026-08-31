using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        //cantidad maxima: 100
        //cantidadActual: inicia en 0
        //metodo de carga: carga al 100 y devuelve el costo de recargar. 50 cada 100


        //CONSTRUCTOR
        public Botella(string color, string material) { 
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }

        //  SOBRECARGAR EL CONSTRUCTOR
        public Botella() { 
            
        }

        //DESTRUCTOR
        ~Botella() { 
            //la logica...
        }
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;


        public int Capacidad
        {
            get { return capacidad; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        //SOLO DEVUELVO EL VALOR DE MATERIAL
        public string Material { 
            get { return material; }
        }

        

        //PROPIEDAD
        /*
        public int Capacidad {
            get { return capacidad; }
            set { capacidad = value; }
        }
        
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

        //Métodos
        public float recargar() {
            cantidadActual = 100;
            if (cantidadActual > 0) {
                int dif = 100 - cantidadActual;
                //100 50
                //dif
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            return 50;
        }
    }
}
