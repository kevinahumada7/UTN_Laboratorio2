using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class Sello
    {
        public static string mensaje;

        public static string Imprimir()
        {
            Console.WriteLine(mensaje);
            Console.ReadLine();
            Console.Clear();

            return mensaje;
        }

        public static void Borrar()
        {
            mensaje = " ";
        }

        public static void ImprimirEnColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(mensaje);
            Console.Clear();
            Console.ResetColor();
        }

        public static string ArmarFormatoMensaje()
        {
            string formato = "*";
            int len = Sello.mensaje.Length;

            for (int i = 0; i <= len; i++)
            {
                formato += "*";
            }

            return formato + "\n" + "*" + Sello.mensaje + "*\n" + formato;
        }
    }
}
