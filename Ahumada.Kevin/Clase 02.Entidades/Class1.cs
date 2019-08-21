using System;

namespace Clase_02.Entidades
{
    public class Sello
    {
        public static string mensaje;

        public static string Imprimir()
        {
            Sello.mensaje = "Este es el mensaje";
            Console.WriteLine(Sello.mensaje);
            return Sello.mensaje;
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Sello.mensaje);
            Console.ResetColor();
        }

        public static string ArmarFormatoMensaje()
        {
            string msg="*";
            int len = Sello.mensaje.Length;
            
            for(int i=0; i<len; i++)
            {
                msg += "*";
            }

            return msg + "\n" + "*" + Sello.mensaje + "*\n" + msg;
        }
    }
}
