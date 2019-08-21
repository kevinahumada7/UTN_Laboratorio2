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
            MyClass.edad = 20;
            string nombre = MyClass.RetornarNombre();

            Console.Clear();


            Console.WriteLine("El nombre es: {0}",nombre);
            MyClass.MostrarEdad();
            ClassLibrary.MyClass.MostrarNombre();

            if(MyClass.CompararNombre("Uli"))
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son diferentes");
            }

 

            Console.ReadLine();
        }
    }
}
