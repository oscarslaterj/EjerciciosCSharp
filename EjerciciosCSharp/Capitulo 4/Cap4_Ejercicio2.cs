using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp.Capitulo_4
{
    class Cap4_Ejercicio2
    {
        static void Main(string[] args)
        {
            double resultado, numero;
            int value;

            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese a que potencia lo quiere elevar: ");
            value = Convert.ToInt16(Console.ReadLine());

            resultado = Math.Pow(numero, value);
            Console.WriteLine("La potencia de " + numero + " elevada a " + value + " potencia es " + resultado);
            Console.ReadLine();
        }
    }
}
