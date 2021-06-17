using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class MaxNumber
    {
        public int MaxIntegerNumber(int firstValue, int SecondValue, int ThirdValue)
        {
            if (firstValue.CompareTo(SecondValue) > 0 && firstValue.CompareTo(ThirdValue) > 0)
            {
                return firstValue;
            }
            if (SecondValue.CompareTo(firstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0)
            {
                return SecondValue;
            }
            if (ThirdValue.CompareTo(firstValue) > 0 && ThirdValue.CompareTo(SecondValue) > 0)
            {
                return ThirdValue;
            }
            return default;
        }
    }
}
