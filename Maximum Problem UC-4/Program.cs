using System;

namespace Maximum_Problem_UC_4
{
   public class Program
    {
       public static void Main(string[] args)
        {

            Console.WriteLine("Enter the Value of Num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value of Num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value of Num3");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value of Num4");
            int num4 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st Number is the greatest among four = " + num1);
                }
                else
                {
                    Console.WriteLine("The 3rd Number is the greatest among four = " + num3);
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The 2nd Number is the greatest among four = " + num2);
            }
            else
            {
                Console.WriteLine("The 3rd Number is the greatest among four = " + num3);
            }
            if (num1 > num4)
            {
                if (num3 > num4)
                {
                    Console.WriteLine("The 3st Number is the greatest among four = " + num3);
                }
                else
                {
                    Console.WriteLine("The 4rd Number is the greatest among four = " + num4);
                }
            }
        }
    }
}
