using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario programador1 = new Usuario(41560125);
            programador1.nombre = "Kevin";
            programador1.apellido = "Ahumada";

            Usuario programador2 = new Usuario(42080715);
            programador2.nombre = "Gabriel";
            programador2.apellido = "Maldonado";

            Usuario admin = new Usuario(42625103);
            admin.nombre = "Luchetti";
            admin.apellido = "Aranda";

            Usuario tester = new Usuario(40426852);
            tester.nombre = "Brenda";
            tester.apellido = "Frias";

            programador1.Mostrar();
            admin.Mostrar();
            programador2.Mostrar();
            tester.Mostrar();

            Console.ReadLine();
        }
    }
}
