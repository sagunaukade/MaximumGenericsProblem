using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArrayElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.11, 2.34, 54.6, 42.3, 64.8 };
            char[] charArray = { 'a', 'b', 'c', 'd', 'e' };
            ArrayElement.ToPrint(intArray);
            ArrayElement.ToPrint(doubleArray);
            ArrayElement.ToPrint(charArray);
            Console.ReadLine();

        }
    }
}
