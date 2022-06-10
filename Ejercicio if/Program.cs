using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            String dato = "";
            Console.WriteLine("Por favor ingrese su edad:");
            dato = Console.ReadLine();
            numero1 = Convert.ToInt32(dato);
            Console.WriteLine("Su edad es:"+ numero1);

            Console.ReadLine();
        }
    }
}
