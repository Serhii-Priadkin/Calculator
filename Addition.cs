using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Addition
    {
        public double firstNum;
        public double secondNum;
        public double sum;
        public Addition(double _firstNum, double _secondNum)
        {
            firstNum = _firstNum;
            secondNum = _secondNum;
        }
        public double Sum
        {
            get
            {
                sum = firstNum + secondNum;
                return sum;
            }
        }
    }
}