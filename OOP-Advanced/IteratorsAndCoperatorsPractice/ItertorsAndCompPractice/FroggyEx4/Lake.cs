using System;
using System.Collections.Generic;
using System.Text;

namespace FroggyEx4
{
   public class Lake
    {
        private int lake;
        private List<int> numbers;


        public Lake(List<int> lake)
        {
            this.Numbers = lake;
            List<int> list = new List<int>();
        }
        //public Lake(int lake)
        //{
        //    Lakeee = lake;
        //    Numbers = numbers;
        //}

        public int Lakeee { get; }//=> lake; set => lake = value; }
        public List<int> Numbers { get; }// => numbers; set => numbers = value; }

        public void StoneInLakes()
        {
            
            if (Lakeee % 2 == 0)
            {
                int evenNum = Lakeee;
                numbers.Add(evenNum);
                 
              //  Lakeee += Lakeee;
            }
            else if (Lakeee % 2 == 1 )
            {
                int oddNum = Lakeee;
                numbers.Add(oddNum);
                //Lakeee += Lakeee;
            }
           
        }
    }
}
