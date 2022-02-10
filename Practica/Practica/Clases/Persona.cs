using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Clases
{
    public class Persona
    {
        private String nombre;
        private String apellido;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
        public Persona()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Edad = 0;
        }
    }
}
