using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Multiplication
    {
        public double firstNum;
        public double secondNum;
        public double mul;
        public Multiplication(double _firstNum, double _secondNum)
        {
            firstNum = _firstNum;
            secondNum = _secondNum;
        }
        public double Mul
        {
            get
            {
                mul = firstNum * secondNum;
                return mul;
            }
        }
    }
}
