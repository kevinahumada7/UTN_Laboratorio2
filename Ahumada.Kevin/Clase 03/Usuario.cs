using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Usuario
    {
        public string nombre;
        public string apellido;
        int legajo;
        public static int cantUsuarios;
        int dni;

        static Usuario()
        {
            cantUsuarios = 0;
        }

        public Usuario(int dni)
        {
            this.nombre = "name";
            this.apellido = "sname";
            this.dni = dni;
            Usuario.cantUsuarios++;
            this.legajo = Usuario.cantUsuarios;

        }

        public void Mostrar()
        {
            Console.WriteLine("ID: {3:D4} | {1} {0} - {2}", this.nombre.PadRight(10, ' '), this.apellido.PadRight(15, ' '), this.dni, this.legajo);
        }
    }
}
