using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArrayElement
{
    internal class ArrayElement
    {
        public static void ToPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write(element);
            }

        }
        public static void ToDisplay<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write(element);

            }
        }
        public static void ToExecute<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write(element);
            }

        }
         

    }


}
