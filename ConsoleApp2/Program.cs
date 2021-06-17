using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxNumber maxNumber = new MaxNumber();
            Console.WriteLine("Finding the maximum number in the following three numbers");
            int Maximum = maxNumber.MaxIntegerNumber(20, 12, 43);
            Console.WriteLine(Maximum);

        }
    }
}
