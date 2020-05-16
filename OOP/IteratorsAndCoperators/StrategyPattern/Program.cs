using System;
using System.Collections.Generic;

namespace StrategyPattern
{
   public class Program
    {
        static void Main()//string[] args)
        {
            int n =int.Parse( Console.ReadLine());

            SortedSet<Person> sortedPeople = new SortedSet<Person>();
            HashSet<Person> peopleByHash = new HashSet<Person>();

            while (n-- > 0)
            {
                string[] args = Console.ReadLine().Split();

                Person p = new Person(args[0],int.Parse(args[1]));

                sortedPeople.Add(p);
                peopleByHash.Add(p);
            }

            Console.WriteLine(string.Join(Environment.NewLine,sortedPeople.Count));
            Console.WriteLine(string.Join(Environment.NewLine,peopleByHash.Count));
        }
    }
}
