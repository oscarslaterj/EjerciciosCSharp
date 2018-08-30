using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp.Capitulo_4
{
    class Cap5_Ejercicio5
    {
        static void Main(string[] args)
        {
            int num = 0;
            int i = 0;
            string dato = "";
            float suma = 0.0f;
            float min = 0.0f;
            float max = 0.0f;

            Console.WriteLine("Digite la cantidad de personas: ");
            dato = Console.ReadLine();
            num = Convert.ToInt32(dato);

            float[] edades = new float[num];

            for (i = 0; i < num; i++)
            {
                Console.WriteLine("Ingrese las edades: ");
                dato = Console.ReadLine();
                edades[i] = Convert.ToSingle(dato);

            }
            for (i = 0; i < num; i++)
            {
                suma = suma + edades[i];
            }
            for (i = 0; i < num; i++)
            {
                if (edades[i] < min)
                    min = edades[i];
            }

            for (i = 0; i < num; i++)
            {
                if (edades[i] > max)
                    max = edades[i];
            }
            Console.WriteLine("la edad maxima es {0}", max);
            Console.WriteLine("la edad minima es {0}", min);

            Console.ReadLine();
        }
    }
}
