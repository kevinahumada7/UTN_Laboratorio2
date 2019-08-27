using System;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona usuario1 = new Persona();
            Persona usuario2 = new Persona();
            Persona usuario3 = new Persona();

            usuario1.nombre = "Kevin";
            usuario1.apellido = "Ahumada";
            usuario1.dni = 43021356;

            usuario2.nombre = "Luchettinni";
            usuario2.apellido = "Aranda";
            usuario2.dni = 42020715;


            Console.WriteLine(usuario1.Mostrar());
            Console.WriteLine(usuario2.Mostrar());
            Console.WriteLine(usuario3.Mostrar());

            Console.ReadLine();

        }
    }
}
