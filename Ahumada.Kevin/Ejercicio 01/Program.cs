using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";

            int input;
            int cant = 5;
            int max = 0;
            int min = 0;
            int acumulador=0;
            float promedio;

            for(int i=0; i<cant; i++)
            {
                Console.Write("Ingresar numero:");
                input = int.Parse(Console.ReadLine());
                
                if(i==0)
                {
                    max = input;
                    min = input;
                }
                else if(input>max)
                {
                    max = input;
                }
                else if(input<min)
                {
                    min = input;
                }

                acumulador = acumulador + input;
            }

            promedio = acumulador / (float)cant;

            Console.Clear();
            Console.WriteLine("Numero Maximo Ingresado: {0}", max);
            Console.WriteLine("Numero Minimo Ingresado: {0}", min);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Total acumulado: {0}\nPromedio: {1}",acumulador,promedio);
            Console.ReadLine();
            
        }
    }
}
