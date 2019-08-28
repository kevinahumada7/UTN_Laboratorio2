using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_4.Entidades;

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa cosa = new Cosa();

            cosa.EstablecerValor(7);
            cosa.EstablecerValor("Kevin Ahumada");
            cosa.EstablecerValor(DateTime.Now);

            Console.WriteLine(cosa.Mostrar());
            Console.ReadLine();

            Cosa cosita = new Cosa();

            Console.WriteLine(cosita.Mostrar());
            Console.ReadLine();

            Cosa cosoRara1 = new Cosa(7);
            Cosa cosoRara2 = new Cosa("River Campeon de America");
            Cosa cosoRara3 = new Cosa(new DateTime(2018,12,9));

            Console.WriteLine(cosoRara1.Mostrar());
            Console.WriteLine(cosoRara2.Mostrar());
            Console.WriteLine(cosoRara3.Mostrar());
            Console.ReadLine();

            Cosa coso = new Cosa(10,"Luchetti",new DateTime(2017,10,26));

            Console.WriteLine(coso.Mostrar());
            Console.ReadLine();

        }
    }
}
