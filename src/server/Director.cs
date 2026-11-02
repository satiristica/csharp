using System;
using Calculator;

namespace RequestsHandler
{
    class Director
    {
        private readonly Calculate calculation = new Calculate();

        public decimal Execute(decimal a, decimal b, char operation)
        {
            switch (operation)
            {
                case '+':
                    return calculation.Add(a, b);

                case '-':
                    return calculation.Sub(a, b);

                case '*':
                    return calculation.Multip(a, b);

                case '/':
                    return calculation.Divide(a, b);

                default:
                    throw new ArgumentException("Unknown ops.");
            }
        }
    }
}