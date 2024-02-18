using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssigmentCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option = "y";
            while (option != "n")
            {
                Console.WriteLine("1-Addition");
                Console.WriteLine("2-Subtraction");
                Console.WriteLine("3-Multiplication");
                Console.WriteLine("4-Division");
                Console.WriteLine("5-Modulus");
                Console.WriteLine("6-Taking Power");
                Console.WriteLine("7-Square Root");
                Console.WriteLine("8-Logarithm");
                Console.WriteLine("9-Taking Sin");
                Console.WriteLine("10-Taking Cosine"); 
                Console.WriteLine("11-Taking Tan");
                int Operation = int.Parse(Console.ReadLine());
                Calculations Values ;
                if (Operation == 1)
                {
                    Console.Write("Enter 1st Number: ");
                    float FirstNumber = float.Parse(Console.ReadLine());
                    Console.Write("Enter 2nd Number: ");
                    float SecondNumber = float.Parse(Console.ReadLine());
                    Values = new  Calculations(FirstNumber, SecondNumber);
                    Console.WriteLine(Values.Addition(Values));
                }
                if (Operation == 2)
                {
                    Console.Write("Enter 1st Number: ");
                    float FirstNumber = float.Parse(Console.ReadLine());
                    Console.Write("Enter 2nd Number: ");
                    float SecondNumber = float.Parse(Console.ReadLine());
                    Values = new Calculations(FirstNumber, SecondNumber);
                    Console.WriteLine(Values.Subtraction(Values));
                }
                if (Operation == 3)
                {
                    Console.Write("Enter 1st Number: ");
                    float FirstNumber = float.Parse(Console.ReadLine());
                    Console.Write("Enter 2nd Number: ");
                    float SecondNumber = float.Parse(Console.ReadLine());
                    Values = new Calculations(FirstNumber, SecondNumber);
                    Console.WriteLine(Values.Multiplication(Values));

                }
                if (Operation == 4)
                {
                    Console.Write("Enter 1st Number: ");
                    float FirstNumber = float.Parse(Console.ReadLine());
                    Console.Write("Enter 2nd Number: ");
                    float SecondNumber = float.Parse(Console.ReadLine());
                    Values = new Calculations(FirstNumber, SecondNumber);
                    Console.WriteLine(Values.Division(Values));
                }
                if (Operation == 5)
                {
                    Console.Write("Enter 1st Number: ");
                    float FirstNumber = float.Parse(Console.ReadLine());
                    Console.Write("Enter 2nd Number: ");
                    float SecondNumber = float.Parse(Console.ReadLine());
                    Values = new Calculations(FirstNumber, SecondNumber);
                    Console.WriteLine(Values.Modulus(Values));
                }
                if (Operation == 6)
                {
                    Console.Write("Enter a Number: ");
                    float FirstNumber = float.Parse(Console.ReadLine());
                    Console.Write("Enter 2nd Number: ");
                    double exponent = double.Parse(Console.ReadLine());
                    Values = new Calculations(FirstNumber, exponent);
                    Console.WriteLine(Values.Power(Values));
                }
                if (Operation == 7)
                {
                    Console.Write("Enter a Number: ");
                    float Number = float.Parse(Console.ReadLine());
                    Values = new Calculations(Number);
                    Console.WriteLine(Values.Sqrt(Values));
                }
                if (Operation == 8)
                {
                    Console.Write("Enter a Number: ");
                    float Number = float.Parse(Console.ReadLine());
                    Values = new Calculations(Number);
                    Console.WriteLine(Values.Logarithm(Values));
                }
                if (Operation == 9)
                {
                    Console.Write("Enter a Number: ");
                    float Number = float.Parse(Console.ReadLine());
                    Values = new Calculations(Number);
                    Console.WriteLine(Values.TakingSine(Values));
                }
                if (Operation == 10)
                {
                    Console.Write("Enter a Number: ");
                    float Number = float.Parse(Console.ReadLine());
                    Values = new Calculations(Number);
                    Console.WriteLine(Values.TakingCosine(Values));
                }
                if (Operation == 11)
                {
                    Console.Write("Enter a Number: ");
                    float Number = float.Parse(Console.ReadLine());
                    Values = new Calculations(Number);
                    Console.WriteLine(Values.TakingTan(Values));
                }

                Console.Write("Do you want to perform another operation? (y/n): ");
                option = Console.ReadLine();
                 
            }
        }
    }
}
