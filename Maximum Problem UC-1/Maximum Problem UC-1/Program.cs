using System;

namespace Maximum_Problem_UC_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IntegerMethod();
        }

        private static void IntegerMethod()
        {
            Console.WriteLine("Enter the Value of Num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value of Num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value of Num3");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st Number is the greatest among three = " + num1);
                }
                else
                {
                    Console.WriteLine("The 3rd Number is the greatest among three = " + num3);
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The 2nd Number is the greatest among three = " + num2);
            }
            else
            {
                Console.WriteLine("The 3rd Number is the greatest among three = " + num3);
            }
        }
    }
}
