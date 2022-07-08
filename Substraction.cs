using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Substraction
    {
        public double firstNum;
        public double secondNum;
        public double sub;
        public Substraction(double _firstNum, double _secondNum)
        {
            firstNum = _firstNum;
            secondNum = _secondNum;
        }
        public double Sub
        {
            get
            {
                sub = firstNum - secondNum;
                return sub;
            }
        }
    }
}
