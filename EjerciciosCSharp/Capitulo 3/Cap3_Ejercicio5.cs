using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp.Capitulo_3
{
    class Cap3_Ejercicio5
    {
        static void Main(string[] args)
        {
            float resultado = 0.0f;
            string valor = " ";
            float lado;
            int opc = 0;
            int cantlado;
            float a;

            Console.WriteLine("1- calcular perimetro");
            Console.WriteLine("2- calcular area");
            valor = Console.ReadLine();
            opc = Convert.ToInt32(valor);

            Console.Write("Digite el valor del lado del poligono regular :");
            valor = Console.ReadLine();
            lado = Convert.ToSingle(valor);

            switch (opc)
            {
                case 1:
                    Console.WriteLine("digite la cantidad de lado del poligono regular :");
                    cantlado = int.Parse(Console.ReadLine());

                    resultado = lado * cantlado;
                    break;

                case 2:
                    Console.WriteLine("digite el apotema del poligono :");
                    a = float.Parse(Console.ReadLine());

                    resultado = (lado * a) / 2;
                    break;

                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
            Console.Write(+resultado + " es el resultado");

            Console.ReadKey();
        }
    }
}
