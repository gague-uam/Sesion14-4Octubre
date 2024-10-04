using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivo.models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Nota { get; set; }
        public char Sexo { get; set; } 

        public Persona(string nombre, int edad, int nota, char sexo)
        {
            Nombre = nombre;
            Edad = edad;
            Nota = nota;
            Sexo = sexo;
        }
    }
}
