using Simple_calculator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_calculator.Services
{
    public class Calculator : ICalculator
    {
        public int Division(int number1, int number2)
        {
            return number1 / number2;
        }

        public int Minus(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
