using System;
using System.Linq;

namespace Ex1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split().Skip(1).ToArray();

            ListyIterator<string> list = new ListyIterator<string>(data);

            string input = Console.ReadLine();

            while (input != "END")
            {
                switch (input)
                {
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNexnt());
                        break;
                    case "Print":
                        try
                        {
                            list.Print();

                        }
                        catch (InvalidOperationException ex)
                        {

                            throw new InvalidOperationException(ex.Message);
                        }
                        break;
                    case "PrintAll":
                        list.PrintAll();
                        break;


                    default:
                        break;
                }



                input = Console.ReadLine();
            }


        }
    }
}
