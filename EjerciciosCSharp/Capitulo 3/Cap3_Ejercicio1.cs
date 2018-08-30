using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp.Capitulo_3
{
    class Cap3_Ejercicio1
    {
        static void Main(string[] args)
        {
            int valor;
            Console.WriteLine("Ingrese un numero para saber si es par o impar: ");
            valor = Convert.ToInt16(Console.ReadLine());

            if ((valor % 2) == 0)
                Console.WriteLine("Es Par");
            else
                Console.WriteLine("Es Impar");
            Console.Read();
        }
    }
}
