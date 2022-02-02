using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxGenericsPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Generics programs");
            Console.Write("Enter First Number : ");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int secondValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            int thirdValue = Convert.ToInt32(Console.ReadLine());
            int resultNum = MaxIntValue.ThreeMaxIntNumber(firstValue, secondValue, thirdValue);
            Console.WriteLine("{0} is maximum value from first: {1} second: {2} third: {3}", resultNum, firstValue, secondValue, thirdValue);
            Console.ReadLine();
        }
    }
}


