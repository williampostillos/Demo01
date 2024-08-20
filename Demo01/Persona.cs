using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Persona
    {
        public Persona(string Nombres, string Apellidos) {
        
        }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String NombresCompletos { get; set; }

        public void AsignarNombresCompletos()
        {
            NombresCompletos = Nombres + " " + Apellidos;
        }

    }
}
