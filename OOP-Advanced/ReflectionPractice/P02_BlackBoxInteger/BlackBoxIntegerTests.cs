namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            //TODO put your reflection code here
            Type type = typeof(BlackBoxInteger);

            var box = (BlackBoxInteger)Activator.CreateInstance(type, true);

            string input = Console.ReadLine();

            while (input != "END")
            {
                string namesOfInput = input.Split('_')[0];
                int numberOfInput = int.Parse(input.Split('_')[1]);

                var method = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                    .First(m => m.Name == namesOfInput);

                method.Invoke(box, new object[] { numberOfInput });

                var result = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                    .First(f => f.Name == "innerValue").GetValue(box);
                    ;

                Console.WriteLine(result);

                input = Console.ReadLine();
            }


        }
    }
}
