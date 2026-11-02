using System;

namespace Calculator 
{
    public class CalculationRequest 
    {
        public decimal value1
        {
            get;
            set;
        }

        public decimal value2
        {
            get;
            set;
        }

        public char ops 
        {
            get;
            set; 
        }
    }
}