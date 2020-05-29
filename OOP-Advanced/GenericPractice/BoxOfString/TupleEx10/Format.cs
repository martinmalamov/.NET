using System;
using System.Collections.Generic;
using System.Text;

namespace TupleEx10
{
   public class Format
    {
        private int integerValue;
        private double doubleValue;

        public Format(int integerValue, int doubleValue)
        {
            IntegerValue = integerValue;
            DoubleValue = doubleValue;
        }

        public int IntegerValue { get { return integerValue; } set {integerValue = value ; } }
        public double DoubleValue { get { return doubleValue; } set {doubleValue = value ; } }

        public override string ToString()
        {
            return $"{IntegerValue} -> {DoubleValue}";
        }
    }
}
