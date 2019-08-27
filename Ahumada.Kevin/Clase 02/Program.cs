using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Hola Mundo";
            Sello.Imprimir();

            Sello.Borrar();
            Sello.Imprimir();

            Sello.mensaje = "Hello World";
            Sello.ImprimirEnColor(ConsoleColor.Cyan);

            Console.Write("Escribir mensaje: ");
            Sello.mensaje = Console.ReadLine();
            Sello.mensaje = Sello.ArmarFormatoMensaje();
            Sello.Imprimir();
            
        }
    }
}
