using System;

namespace Ex1
{
   public class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(3,4);

           Console.WriteLine(point.Y.CompareTo(point.X)); //1
            

            
        }
    }
}
