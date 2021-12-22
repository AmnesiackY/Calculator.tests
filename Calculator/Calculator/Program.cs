using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello user!");
            Console.WriteLine("Choose operation: \n\t1 - Sum \n\t2 - Sub \n\t3 - Div \n\t4 - Mult \n\t5 - Square");
            int num = check_value(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Enter first number");
                    int a = check_value(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int b = check_value(Console.ReadLine());
                    int result_sum = Measurments.Sum(a, b);
                    Console.WriteLine($"You result is {result_sum}");
                    break;
                case 2:
                    Console.WriteLine("Enter first number");
                    int c = check_value(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int d = check_value(Console.ReadLine());
                    int result_sub = Measurments.Sub(c, d);
                    Console.WriteLine($"You result is {result_sub}");
                    break;
                case 3:
                    Console.WriteLine("Enter first number");
                    int e = check_value(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int f = check_value(Console.ReadLine());
                    double result_div = Measurments.Div(e, f);
                    Console.WriteLine($"You result is {result_div}");
                    break;
                case 4:
                    Console.WriteLine("Enter first number");
                    int g = check_value(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int h = check_value(Console.ReadLine());
                    int result_mult = Measurments.Mult(g, h);
                    Console.WriteLine($"You result is {result_mult}");
                    break;
                case 5:
                    Console.WriteLine("Enter number");
                    int i = check_value(Console.ReadLine()); ;
                    double result_square = Measurments.Square(i);
                    Console.WriteLine($"You result is {result_square}");
                    break;
                default: throw new ArgumentException("Enter correct number");
            }
        }
        public static int check_value(string str_check)
        {
            int str_int32;
            while (!Int32.TryParse(str_check, out str_int32))
            {
                Console.WriteLine("Symbols uncorrect! Try again ");
                str_check = Console.ReadLine();
            }
            return str_int32;
        }
    }
}
