using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase_02.Entidades;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*MyClass.edad = 20;
            MyClass.nombre = "Kevin";

            string nombre = MyClass.RetornarNombre();
            Console.Clear();

            Console.WriteLine("El nombre es: {0}",nombre);
            MyClass.MostrarEdad();
            ClassLibrary.MyClass.MostrarNombre();

            if(MyClass.CompararNombre(nombre))
            {
                Console.WriteLine("Los nombres son iguales",MyClass.nombre,nombre);
            }
            else
            {
                Console.WriteLine("Los nombres son diferentes: {0} y {1}", MyClass.nombre, nombre);
            }*/

            Sello.mensaje = "Hola Mundo";
            Console.WriteLine(Sello.mensaje);

            Sello.mensaje = Sello.Imprimir();

            Sello.Borrar();
            Console.WriteLine(Sello.mensaje);

            Sello.mensaje = "Hola";
            Sello.ImprimirEnColor();

            Sello.ArmarFormatoMensaje();
            Console.WriteLine(Sello.mensaje);

            Console.ReadLine();
        }
    }
}
