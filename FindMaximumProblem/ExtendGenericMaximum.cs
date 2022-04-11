using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblem
{
    class ExtendGenericMaximum<T> where T : IComparable
    {
        //Instance Variable Generic 
        public T[] value;

        //Parameter Constructor
        public ExtendGenericMaximum(T[] value)
        {
            this.value = value;
        }

        //Taking Values and Make Sort
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        //Taking Values and Make Sort
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[sorted_values.Length-1];
        }

        //Returning Max Value
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

        //To Print The Value
        internal void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum Value is : " + max);

        }

    }
}
