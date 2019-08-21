using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    //[modificador] clase NombreClase
    //Se debe definir el modificador de visibilidad como public o si no lo defino es private
    public class MyClass
    {
        //Miembro static -> "De Clase"
        //Miembreo no static (no se define) -> "De Instancia"

        //[Modificador] Tipo NombreDelMetodo(Parametro si es requerido)
        public static string nombre="Kevin";
        public static int edad;

        public static void MostrarEdad()
        {
            Console.WriteLine("La edad es: {0}",edad);
            Console.ReadLine();
        }

        public static string RetornarNombre()
        {
            Console.Write("Ingresar nombre: ");
            MyClass.nombre = Console.ReadLine();
            return MyClass.nombre;
        }

        public static bool CompararNombre(string nombreParam)
        {
            bool allOK = false;

            if(MyClass.nombre==nombreParam)
            {
                allOK = true;
            }

            return allOK;
        }
    }
}
