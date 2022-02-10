
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Clases
{
    class Alumno : Persona
    {
        private String carnet;
        private String carrera;
        private String facultad;

        public Alumno(string nombre, string apellido, int edad, string carnet, string carrera, string facultad) : base(nombre, apellido, edad)
        {
            this.carnet = carnet;
            this.carrera = carrera;
            this.facultad = facultad;
        }

        public string Carnet { get => carnet; set => carnet = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Facultad { get => facultad; set => facultad = value; }




    }
}
