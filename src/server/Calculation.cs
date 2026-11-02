using System;

namespace Calculator
{
    class Calculate 
    {
        public decimal Add(decimal a, decimal b)
        {   
            return a+b;
        }
        
        public decimal Sub(decimal a, decimal b)
        {
            return a-b;
        }

        public decimal Multip(decimal a, decimal b)
        {
            return a-b;
        }

        public decimal Divide(decimal a, decimal b)
        {   
            if (b==0) {
                throw new DivideByZeroException("DO NOT DIVIDE BY 0");
            }
            return a-b;
        }

        // private bool Validate(decimal a, decimal b) {};
    }
}