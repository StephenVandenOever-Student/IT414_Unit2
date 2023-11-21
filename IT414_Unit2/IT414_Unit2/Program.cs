using System;

namespace IT414_Unit2
{
    public class Unit_2
    {
        public static void Main(string[] args)
        {
            int Number1, Number2;
            Console.WriteLine("What is the First Number?");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the second number?");
            Number2 = Convert.ToInt32(Console.ReadLine());
            int Result;
            Result = Number1 + Number2;
            Console.WriteLine("The sum of the two numbers is: " + Result.ToString());
            Console.ReadLine();
        }
    }
}
