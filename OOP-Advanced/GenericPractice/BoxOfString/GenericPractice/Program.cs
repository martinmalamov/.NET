using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxOfStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<double> messages = new List<double>();

            for (int i = 0; i < n; i++)
            {
                //  Console.WriteLine(box);
                double message = double.Parse(Console.ReadLine());
                messages.Add(message);

            }
            //int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double element = double.Parse(Console.ReadLine());
            Box<double> box = new Box<double>(messages);

          
           int result =  box.GreaterElement(element);
            Console.WriteLine(result);
        }
    }
}
