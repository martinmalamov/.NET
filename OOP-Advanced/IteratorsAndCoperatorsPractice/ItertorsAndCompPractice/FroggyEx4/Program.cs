using System;
using System.Collections.Generic;
using System.Linq;

namespace FroggyEx4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(new char[] { ' ',','},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            Lake lake = new Lake(numbers);

            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 1)
                {
                    evenList.Add(numbers[i]);
                   
                }
                else if(i % 2 == 0)
                {
                    oddList.Add(numbers[i]);
                }
            }
            evenList.Reverse();
            Console.Write(string.Join(", ", oddList));
            Console.Write(", ");
            Console.WriteLine(string.Join(", ",evenList));


          
        }
    }
}
