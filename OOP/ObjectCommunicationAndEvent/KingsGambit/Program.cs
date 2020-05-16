using System;

namespace KingsGambit
{
    class Program 
    {
        static void Main(string[] args)
        {
           
            new Engine(new ConsoleReader(), new ConsoleWriter()).Run();

        }   
    }
}
