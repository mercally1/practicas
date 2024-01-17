using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    partial class Rectangulo
    {
        public int RetornarSuperficie()
        {
            int sup = lado1 * lado2;
            return sup;
        }

        public int RetornarPerimetro()
        {
            int per = lado1 * 2 + lado2 *2;
            return per;
        }
    }
}
