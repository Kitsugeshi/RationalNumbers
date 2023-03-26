using System;

namespace RationalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            RationalNums num1 = new RationalNums(a, b);
            num1.Print();
            Console.WriteLine("\n");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            RationalNums num2 = new RationalNums(c, d);
            num2.Print();
            Console.WriteLine("\n");
            RationalNums res1 = num1 + num2;
            Console.Write("Результат сложения: ");
            res1.Print();
            Console.WriteLine("\n");
            RationalNums res2 = num1 - num2;
            Console.Write("Результат вычитания: ");
            res2.Print();
            Console.WriteLine("\n");
            RationalNums res3 = num1 * num2;
            Console.Write("Результат умножения: ");
            res3.Print();
            Console.WriteLine("\n");
            RationalNums res4 = num1 / num2;
            Console.Write("Результат деления: ");
            res4.Print();
            Console.WriteLine("\n");
            bool flag = num1 > num2;
            if (flag)
            {
                num1.Print();
                Console.Write(" > ");
                num2.Print();
                
            }
            bool flag2 = num1 < num2;
            if (flag2)
            {
                num1.Print();
                Console.Write(" < ");
                num2.Print();
            }
        }
    }
}
