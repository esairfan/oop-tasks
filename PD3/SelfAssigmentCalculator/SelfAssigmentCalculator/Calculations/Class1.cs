using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssigmentCalculator
{
    internal class Calculations
    {
        public float FirstNumber;
        public float SecondNumber;
        public double exponent;
        public Calculations() 
        {
        }
        public Calculations(float Number1,float Number2)
        {
            FirstNumber  = Number1 ;
            SecondNumber = Number2 ;
        }
        public Calculations(float Number, double exponent)
        {
            FirstNumber = Number;
            this.exponent = exponent;
        }
        public Calculations(float Number)
        {
            FirstNumber = Number;
        }

        public float Addition(Calculations Values)
        {
            return Values.FirstNumber + Values.SecondNumber;
        }
        public float Subtraction(Calculations Values)
        {
            return Values.FirstNumber - Values.SecondNumber;
        }
        public float Multiplication(Calculations Values)
        {
            return Values.FirstNumber * Values.SecondNumber;
        }
        public float Division(Calculations Values)
        {
            return Values.FirstNumber / Values.SecondNumber;
        }
        public float Modulus(Calculations Values)
        {
            int a;
             
                a = Convert.ToInt32(Division(Values));
                a = Convert.ToInt32(a * SecondNumber);
                a = Convert.ToInt32(FirstNumber - a);
                if (a < 0)
                {
                    a = Convert.ToInt32(a + SecondNumber);
                } 
            return a;
        }
        public double Power(Calculations Values)
        {
            return Convert.ToDouble(Math.Pow(Values.FirstNumber,Values.exponent));
        }
        public double Sqrt(Calculations Values)
        {
            return Convert.ToDouble(Math.Sqrt(Values.FirstNumber));
        }
        public double Logarithm(Calculations Values)
        {
            return Convert.ToDouble(Math.Log(Values.FirstNumber));
        }
        public double TakingSine(Calculations Values)
        {
            return Convert.ToDouble(Math.Sin(Values.FirstNumber));
        }
        public double TakingCosine(Calculations Values)
        {
            return Convert.ToDouble(Math.Cos(Values.FirstNumber));
        }
        public double TakingTan(Calculations Values)
        {
            return Convert.ToDouble(Math.Tan(Values.FirstNumber));
        }

    }
}
