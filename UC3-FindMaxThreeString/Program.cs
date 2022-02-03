using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_FindMaxThreeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the finding maximum number program using generics");

            while (true)
            {
                Console.WriteLine("\n1.Find Max Of three Int Number" + "\n2.Find Max Of Three Float Number" + "\n3.Exit");
                Console.Write("Enter Your Choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int firstIntValue = 80, secondIntValue = 20, totalIntValue = 10;
                        int resIntNum = MaxIntValue.MaxIntNumThree(firstIntValue, secondIntValue, totalIntValue);
                        Console.WriteLine("{0} is maximum value from first: {1} second: {2} third: {3}", resIntNum, firstIntValue, secondIntValue, totalIntValue);
                        Console.ReadLine();
                        break;
                    case 2:
                        float fFtVal = 2.2f, sFtVal = 4.4f, tFtVal = 3.2f;
                        float resFtNum = MaxFloatValue.MaxFloatNumThree(fFtVal, sFtVal, tFtVal);
                        Console.WriteLine("{0} is maximum value from first: {1} second: {2} third: {3}", resFtNum, fFtVal, sFtVal, tFtVal);
                        Console.ReadLine();
                        break;
                    case 3:
                        string fstStr = "Sagu", secStr = "Saguna", thirdStr = "sag";
                        string resStr = FindMaxString.MaxStringThree(fstStr, secStr, thirdStr);
                        Console.WriteLine("{0} is maximum value from first: {1} second: {2} third: {3}", resStr, fstStr, secStr, thirdStr);
                        Console.ReadLine();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Exit");
                        break;
                }
            }
        }
    }
    
}
