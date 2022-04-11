using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welcome to Maximum Number");

            int[] intArray = { 34, 23, 12, 36 };
            double[] doubleArray = { 12.5, 45.65, 987.45, 658.78 };
            string[] stringArray = { "Apple", "Peach", "Banana" };

            // Passing integer input with max number at first place
            ExtendGenericMaximum<int> extendGenericMaximum = new ExtendGenericMaximum<int>(intArray);
            int outputInt = extendGenericMaximum.MaxMethod();

            ExtendGenericMaximum<double> extendGenericMaximum1 = new ExtendGenericMaximum<double>(doubleArray);
            double outputDouble = extendGenericMaximum1.MaxMethod();

            ExtendGenericMaximum<string> extendGenericMaximum2 = new ExtendGenericMaximum<string>(stringArray);
            string outputString = extendGenericMaximum2.MaxMethod();


            //Display Output
            Console.WriteLine("Integer Max : " + outputInt);
            Console.WriteLine("Float Max : " + outputDouble);
            Console.WriteLine("String Max : " + outputString);

            Console.ReadLine();

        }
    }
}
