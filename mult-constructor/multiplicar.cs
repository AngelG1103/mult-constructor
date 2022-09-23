using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mult_constructor
{
    class multiplicar
    {
        public double V1;
        public double V2;

        public multiplicar()
        {
        }

        public multiplicar(double v1, double v2)
        {
            V1 = v1;
            V2 = v2;
        }
        public double multipica()
        {
            return V1 * V2;
        }
    }
}
