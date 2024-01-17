using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Lado1 = 5;
            rectangulo.Lado2 = 10;
            Console.WriteLine("La superficie de rectangulo es: " + rectangulo.RetornarSuperficie());
            Console.WriteLine("La superficie de rectangulo es: " + rectangulo.RetornarPerimetro());
            Console.ReadKey();
        }
    }
}
   
