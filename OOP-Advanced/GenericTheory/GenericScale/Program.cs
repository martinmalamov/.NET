using System;

namespace GenericScale
{
    class Program
    {
        static void Main(string[] args)
        {
            var scale = new Scale<int>(5,10);
            Console.WriteLine(scale.GetHeavier());

            var scale2 = new Scale<string>("Men","Women");
            Console.WriteLine(scale2.GetHeavier());
        }
    }
}
