using System;

namespace CustomList
{
    public class Program 
    {
        static void Main(string[] args)
        {
          var list = new Box<string>();
            string command; 

            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case "Add":
                        list.Add(tokens[1]);
                        break;
                    case "Remove":
                        list.Remove(int.Parse(tokens[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(list.Contains(tokens[1]));
                        break;
                    case "Swap":
                        list.Swap(int.Parse(tokens[1]),int.Parse(tokens[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(list.CountGreaterThan(tokens[1]));
                        break;
                    case "Max":
                        Console.WriteLine(list.Max());
                        break;
                    case "Min":
                        Console.WriteLine(list.Min());
                        break;
                    case "Sort":
                        Sorter.Sort(ref list);
                        break;
                    case "Print":
                        //Console.WriteLine(list);
                        foreach (var item in list)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    default:
                        throw new ArgumentException();
                        break;
                }
                
            }
        }
    }
}
