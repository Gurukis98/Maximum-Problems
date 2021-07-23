using System;

namespace Maximum_Problem_UC_5
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int[] Integer = new int[] { 1, 2, 3, 4 };
            int maximumNumber = Integer.Max();
            Console.WriteLine("The Greatest Integer: " + maximumNumber);

            float[] Float = new float[] { 1.1f, 2.5f, 7.5f, 4.3f };
            float maximumFloat = Float.Max();
            Console.WriteLine("The Greatest Float: " + maximumFloat);

            string[] String = new string[] { "Apple", "Peach", "Banana", "Watermelon" };
            string maximumString = String.Max();
            Console.WriteLine("The Greatest String: " + maximumString);
        }
    }
}
