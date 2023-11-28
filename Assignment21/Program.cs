using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21
{
    public class Calculation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
    }


    public delegate int ArithmeticOperation(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Calculation calc = new Calculation();
            Console.WriteLine("Enter first number");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondnumber = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Choose the oprations 1.Addition 2.Subtraction 3.Multiplication 4.Division");
                int op = int.Parse(Console.ReadLine());
                ArithmeticOperation arithmetic;
                switch (op)
                {
                    case 1:
                        {
                            arithmetic = new ArithmeticOperation(Calculation.Add);
                            Console.WriteLine("Addition of two numbers " + arithmetic(firstnumber, secondnumber));
                            break;
                        }
                    case 2:
                        {
                            arithmetic = new ArithmeticOperation(Calculation.Subtract);
                            Console.WriteLine("Addition of two numbers " + arithmetic(firstnumber, secondnumber));
                            break;
                        }
                    case 3:
                        {
                            arithmetic = new ArithmeticOperation(Calculation.Multiply);
                            Console.WriteLine("Addition of two numbers " + arithmetic(firstnumber, secondnumber));
                            break;
                        }
                    case 4:
                        {
                            arithmetic = new ArithmeticOperation(Calculation.Divide);
                            Console.WriteLine("Addition of two numbers " + arithmetic(firstnumber, secondnumber));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("invalid option");
                            break;

                        }
                }
                Console.WriteLine("Do you wanna continue press y/n");
                choice = Console.ReadLine();
            } while (choice == "y");

        }
    }
}