using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblem
{
    class GenericMaximum<T> where T : IComparable
    {
        // Instance variables
        public T firstValue, secondValue, thirdValue;

        // Constructor
        public GenericMaximum(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }

        // Generic method to find maximum value
        public static T MaximumNumber(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }

            throw new Exception("All three values are same");
        }

        // Generic method to call maximum method
        public T MaxMethod()
        {
            T maxNumber = GenericMaximum<T>.MaximumNumber(this.firstValue, this.secondValue, this.thirdValue);
            return maxNumber;
        }
    }
}
