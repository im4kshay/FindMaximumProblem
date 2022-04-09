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

            //Maximum Number At Second Place
            int outputInteger = maximumNumberCheck.MaximumIngerNumber(41, 82, 33);

            //Display Output
            Console.WriteLine("Maximum Number of Integer : " + outputInteger);

            Console.ReadLine();
        }
    }
}
