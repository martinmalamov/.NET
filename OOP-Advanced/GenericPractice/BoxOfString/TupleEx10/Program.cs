using System;
using System.Collections.Generic;
using System.Linq;

namespace TupleEx10
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] name = Console.ReadLine().Split();
            string fullName = name[0] + " " + name[1];
            string adress = name[2];
            string town = name[3];

            string[] info = Console.ReadLine().Split();
            string firstName = info[0];
            int amount = int.Parse(info[1]);
            string trueOrFalse = info[2];

            bool resultTrue = true;
            if (trueOrFalse == "drunk")
            {
                 resultTrue = true;

            }
            else
            {
                 resultTrue = false;

            }


            string[] number = Console.ReadLine().Split();
            string thirdName = number[0];
            double doubleNum = double.Parse(number[1]);
            string bank = number[2];


            SpecialTuple<string, string, string> personTuple = new SpecialTuple<string, string, string>(fullName, adress, town);
            SpecialTuple<string, int, bool> personTuple2 = new SpecialTuple<string, int, bool>(firstName, amount,resultTrue);
            SpecialTuple<string, double, string> personTuple3 = new SpecialTuple<string, double, string>(thirdName, doubleNum, bank);

            Console.WriteLine(personTuple);
            Console.WriteLine(personTuple2);
            Console.WriteLine(personTuple3);


        }
    }
}
