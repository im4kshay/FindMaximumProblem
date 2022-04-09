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
            Console.WriteLine("=-=-=-=-=-Welcome to the Find Maximum Problem using Generics-=-=-=-=-=");

            //Calling Class to call a Function
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();

            //Maximum Number At First Place
            double outputFloat1 = maximumNumberCheck.MaximumFloatNumber(14.1, 2.82, 7.33);
            Console.WriteLine("Maximum Number of Float at First Place : " + outputFloat1);

            //Maximum Number At Second Place
            double outputFloat2 = maximumNumberCheck.MaximumFloatNumber(4.1, 28.2, 12.8);
            Console.WriteLine("Maximum Number of Integer at Second Place : " + outputFloat2);

            //Maximum Number At Third Place
            double outputFloat3 = maximumNumberCheck.MaximumFloatNumber(75.9, 68.47, 77.3);
            Console.WriteLine("Maximum Number of Integer at Third Place : " + outputFloat3);

            Console.ReadLine();
        }
    }
}
