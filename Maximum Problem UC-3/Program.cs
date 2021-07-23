using System;

namespace Maximum_Problem_UC_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StringMethod();
        }

        private static void StringMethod()
        {
            string str1 = "Apple";
            string str2 = "Peach";
            string str3 = "Banana";

            int strLength1 = str1.Length;
            int strLength2 = str2.Length;
            int strLength3 = str3.Length;

            if (strLength1 > strLength2)
            {
                if (strLength1 > strLength3)
                {
                    Console.WriteLine("The 1st String is the greatest among three = " + str1);
                }
                else
                {
                    Console.WriteLine("The 3rd String is the greatest among three = " + str3);
                }
            }
            else if (strLength2 > strLength3)
            {
                Console.WriteLine("The 2nd String is the greatest among three = " + str2);
            }
            else
            {
                Console.WriteLine("The 3rd String is the greatest among three = " + str3);
            }
        }
    }
}
