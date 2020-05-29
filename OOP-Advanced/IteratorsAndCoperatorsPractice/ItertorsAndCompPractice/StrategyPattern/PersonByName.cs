using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class PersonByName : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            int result = first.Name.Length.CompareTo(second.Name.Length);

            if (result == 0 )
            {
                char firstPersonLetter = Char.ToLower(first.Name[0]);
                char secondPersonLetter = Char.ToLower(second.Name[0]);

                result = firstPersonLetter.CompareTo(secondPersonLetter);


            }
            return result;
        }
    }
}
