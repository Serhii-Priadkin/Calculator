using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Division
    {
        public double firstNum;
        public double secondNum;
        public double div;
        public Division(double _firstNum, double _secondNum)
        {
            firstNum = _firstNum;
            secondNum = _secondNum;
        }
        public double Div
        {
            get
            {
                div = firstNum / secondNum;
                return div;
            }
        }
    }
}
