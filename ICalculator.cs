using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_calculator.Interface
{
    public interface ICalculator
    {
        int Sum(int number1,int number2);
        int Minus(int number1, int number2);
        int Division(int number1, int number2);
        int Multiplication(int number1, int number2);
    }
}
