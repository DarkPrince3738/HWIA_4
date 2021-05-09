using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(12, 5, 9);
            Add();
            Sub();
            Mul();
            Div();
            Conv();
            AboutNum(17);
        }

        static void Calculate(int x ,int y, int z)
        {
            Console.WriteLine("Task1");
            Console.WriteLine((x+y+z)/3.0);
            Console.WriteLine("Task3");
        }
        static void Add()
        {
            Console.WriteLine("Add =");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x+y);
        }
        static void Sub()
        {
            Console.WriteLine("Sub =");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x-y);
        }
        static void Mul()
        {
            Console.WriteLine("Mul =");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x*y);
        }
        static void Div()
        {
            Console.WriteLine("Div =");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (y == 0)
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine(x/y);
        }
        static void Conv()
        {
            Console.WriteLine("Task 4");
            Console.WriteLine("Write cont of your money & val");
            int sum = int.Parse(Console.ReadLine());
            int conv = int.Parse(Console.ReadLine());
            Console.WriteLine(sum*conv);
        }
        static void AboutNum(int num)
        {
            Console.WriteLine("Task5");
            if (num >= 0)
            {
                Console.WriteLine("Num >= 0");
            }
            else
            {
                Console.WriteLine("Num < 0");
                num -= (num * 2);
            }
            int k = 0;
            for(int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    k++;
                }
            }
            if (k == 2)
            {
                Console.WriteLine("Num is common");
            }
            else
            {
                Console.WriteLine("Num isn't common");
            }
            if(num%2==0 && num%3==0 && num%5==0 && num%6==0 && num % 9 == 0)
            {
                Console.WriteLine("Num div 2, 3, 5, 6, 9");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
