using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp.Capitulo_2
{
    class Cap2_Ejercicio5
    {
        static void Main(string[] args)
        {
            double dolares;
            double ceuros = 0,836084749;
            string valor;
            Console.WriteLine("Digitar Monto de dolares a convertir a Euros:");
            valor = Console.ReadLine();
            dolares = Convert.ToDouble(valor);
            conversion = dolares * ceuros;

            Console.WriteLine("{0} Dolares = {1} Euros", dolares, conversion);

        }
    }
}
