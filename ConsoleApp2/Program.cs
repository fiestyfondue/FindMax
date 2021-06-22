using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Find Maximum of Numbers program");
             string maxNum = FindMaxNumber.FindMax("Apple", "Banana", "Peach");
             Console.WriteLine(maxNum);   
        }
    }
}
