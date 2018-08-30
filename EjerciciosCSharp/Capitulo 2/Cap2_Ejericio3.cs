using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp.Capitulo_2
{
    class Cap2_Ejericio3
    {
        static void Main(string[] args)
        {
            float Nlados;
            float Vlados;
            string valor;

            Console.WriteLine("Digite Los lados del angulo:");
            valor = Console.ReadLine();
            Nlados = Convert.ToSingle(valor);
            Console.WriteLine("Digite el valor de los lados: ");
            valor = Console.ReadLine();
            Vlados = Convert.ToSingle(valor);
            float perimetro = Nlados * Vlados;
            Console.WriteLine("El perimetro es: {0} ", perimetro);
            Console.Read();
        }
    }
}
