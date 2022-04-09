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
            string outputString1 = maximumNumberCheck.MaximumStringNumber("Peach", "Apple", "Banana");
            Console.WriteLine("Maximum Number of String at First Place : " + outputString1);

            //Maximum Number At Second Place
            string outputString2 = maximumNumberCheck.MaximumStringNumber("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum Number of String at Seond Place : " + outputString2);

            //Maximum Number At Third Place
            string outputString3 = maximumNumberCheck.MaximumStringNumber("Apple", "Banana", "Peach");
            Console.WriteLine("Maximum Number of String at Third Place : " + outputString3);

            Console.ReadLine();
        }
    }
}
