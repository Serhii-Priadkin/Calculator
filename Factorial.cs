using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Factorial
    {
        public int fac(int firstNum)
        {
            if (firstNum == 1)
                return 1;
            else
                return firstNum * fac(firstNum - 1);
        }

    }
}
