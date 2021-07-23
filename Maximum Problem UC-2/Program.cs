using System;

namespace Maximum_Problem_UC_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FloatMethod();
        }

        private static void FloatMethod()
        {
            Console.WriteLine("Enter the Value of Num1");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value of Num2");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value of Num3");
            float num3 = float.Parse(Console.ReadLine());

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
