using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Construtor
{
    internal class Construtor
    {
        private int[] sueldo;
        public Construtor()
        {
            sueldo = new int[5];
            for (int i = 0; i < sueldo.Length; i++)
            {
                Console.WriteLine("ingrese el sueldo:");
                sueldo[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Print()
        {
            for (int i = 0; i < sueldo.Length; i++)
            {
                Console.WriteLine(sueldo[i]);
            }
            Console.ReadKey();
        }
       
        static void Main(string[] args)
        {
            Construtor con = new Construtor();
            con.Print();
        }
    }
}
