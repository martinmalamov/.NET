﻿using System;
using System.Linq;

namespace StackExercise3
{
   public class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(new char[] {' ', ',' },StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();

            Stack<string> stack = new Stack<string>();

            foreach (var str in data)
            {
                stack.Push(str);
            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                switch (input)
                {

                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                            
                        }
                        break;
                    default:
                        string element = input.Split()[1];
                        stack.Push(element);
                        break;
                }
                    input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("\n",stack));
            Console.WriteLine(string.Join(Environment.NewLine, stack));
        }
    }
}
