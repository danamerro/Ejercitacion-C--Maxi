using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        //Persona: Edad, Sueldo, Nombre

        //ATRIBUTOS / MIEMBROS
        private int edad;
        private float sueldo;
        private string nombre;
        //una forma de hacerla (no hay que hacerla asi)
        public void setEdad(int e) {
            edad = e;
        }

        public int getEdad() { return edad; }

        //asi se hace
        public float Sueldo { 
            get { return sueldo; } 
            set {  sueldo = value; }    
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }




    }
}
