using System;
using System.Reflection.Metadata.Ecma335;

namespace Calculation 
{
    class Calculator
    {
        private double add(double a, double b)
        {
            return a+b;
        }

        private double sub(double a, double b)
        {
            return a-b;
        }
        
        private double multip(double a, double b)
        {
            return a*b;
        }
        
        private double div(double a, double b) 
        {
            if (b == 0)
            {
                Console.WriteLine("Do not divide by 0!");
            }

            return a/b;
        }
    }
}