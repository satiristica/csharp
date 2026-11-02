using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("first value:");
            double a = Convert.ToDouble(Console.ReadLine());


            Console.Write("second value:");
            double b = Convert.ToDouble(Console.ReadLine());


            Console.Write("ops:");
            string ops = Console.ReadLine();

            double res;

            switch (ops)
            {
                case "+":
                    res = a + b;
                    break;

                case "-":
                    res = a - b;
                    break;

                case "*":
                    res = a * b;
                    break;

                case "/":
                    if (b == 0) {
                        throw new DivideByZeroException("divided by 0!");
                    }
                    res = a / b;
                    break;

                default:
                    Console.WriteLine("unknown ops");
                    return;
            }

            Console.WriteLine("result: "+ res);
        }
        
    }
}
