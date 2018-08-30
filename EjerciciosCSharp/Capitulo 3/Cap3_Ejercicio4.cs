using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp.Capitulo_3
{
    class Cap3_Ejercicio4
    {
        static void Main(string[] args)
        {
            int d;
            Console.WriteLine("Ingrese un numero para saber que dia de la semana es: ");
            d = Convert.ToInt16(Console.ReadLine());
            switch (d)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    Console.Read();
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    Console.Read();
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    Console.Read();
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    Console.Read();
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    Console.Read();
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    Console.Read();
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    Console.Read();
                    break;

            }
        }
}
