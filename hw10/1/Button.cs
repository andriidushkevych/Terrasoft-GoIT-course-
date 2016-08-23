using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Button
    {
        public event OperationEvent calcutate;

        public void Calculate()
        {
            if(calcutate != null)
            calcutate();
        }
    }
}
