using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class PersonByAge : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            int result = first.Age.CompareTo(second.Age);

            if (result == 0 )
            {
                int firstNumber = first.Age;
                int secondNum = second.Age;

                result = firstNumber.CompareTo(secondNum);

            }

            return result;
        }
    }
}
