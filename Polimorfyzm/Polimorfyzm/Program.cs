using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfyzm
{
    internal class Program
    {

        class Calculator
        {
            public void Add(int a, int b)
            {
                Console.WriteLine($"{a}+{b}={a+b}");
            }

            public void Add(double a, double b)
            {
                Console.WriteLine($"{a}+{b}={a + b}");
            }

            public void Add(int a, int b, int c)
            {
                Console.WriteLine($"{a}+{b}+{c}={a + b + c}");
            }
        }
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Add(2, 3);
            calculator.Add(4.5, 5.2);
            calculator.Add(1, 2, 3);
        }
    }
}
