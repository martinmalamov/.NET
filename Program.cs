using System;

namespace test2222
{
    class Program
    {
        static void Main(string[] args)
        {
            ////ex1
            //int[] arrayOfNumbers = { 89, -123, 45, 196, 1204, 0, 112  };

            //int result = 0;
            //  for (var i = 0; i < arrayOfNumbers.Length; i++)
            //{
            //    result += arrayOfNumbers[i];
            //}
            //Console.WriteLine(result);
            ////ex2
            //var num = 0;
            //for (int i = 0; i < arrayOfNumbers.Length; i++)
            //{
            //    if (num < arrayOfNumbers[i])
            //    {
            //        num = arrayOfNumbers[i];
            //    }

            //}
            //Console.WriteLine(num);

            ////ex4
            //var sum = 0;
            //double total = 0;
            //for (int i = 0; i < arrayOfNumbers.Length; i++)
            //{
            //        sum += arrayOfNumbers[i];

            //}
            //total = (double)sum / arrayOfNumbers.Length ;

            //Console.WriteLine($"{total:F4}");


            //ex5 : Да се състави програма, чрез която се въвеждат 7 цели числа от интервала [-5000..5000]
            // в едномерен масив. Програмата да изведе средната стойност на въведените числа като се взема абсолютната им стойност.
            //int[] arrayOfNumbers = { 89, -123, 45, 196, 1204, 0, 112 };
            //var result = 0;
            //double result1 = 0;
            //for (int i = 0; i < arrayOfNumbers.Length; i++)
            //{
            //    if (arrayOfNumbers[i] < 0)
            //    {
            //        result += arrayOfNumbers[i] * -1;
            //    }
            //    else 
            //    {

            //         result += arrayOfNumbers[i];
            //    }

            //}
            // result1 = (double) result / arrayOfNumbers.Length;


            //Console.WriteLine(result1);


            double[] arrayOfNumbers = { -3.2, 1.8 , 2.5, -3.5 ,1.4, -2.6 ,7 };
            double result = 0;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] < 0)
                {
                    result += arrayOfNumbers[i] * -1;
                }
                else
                {

                    result += arrayOfNumbers[i];
                }

            }
                 var   result1 = result ;

           
            Console.WriteLine(result1);

           // number is 22  ,   count of number is 2 !
            var res =  result1.ToString().Length;
            Console.WriteLine(res);
        }
    }
}
