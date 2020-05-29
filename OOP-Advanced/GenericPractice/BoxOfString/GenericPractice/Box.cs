using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BoxOfStrings
{
    public class Box<T> where T : IComparable<T>
    {
        public Box(List<T> items)
        {
            this.Items= items;
        }

        public List<T> Items { get; set; }

        //public override string ToString()
        //{
        //    return $"{this.Item.GetType().FullName}: {Item}";
        //}

        //public void Swap(int index1 , int index2)
        //{
        //    T temp = this.Items[index1];
        //    this.Items[index1] = this.Items[2];
        //    this.Items[2] = temp;
        //}
        public int GreaterElement(T inputItem)
        {
            //T firstElement = this.Items[index];
            //int count = 0;
            //if ( firstElement.Equals(index))
            //{
            //     count = 1;
            //}
            int count = 0;
            foreach (var item in this.Items)
            {
                if (item.CompareTo(inputItem) > 0)
                {
                    count++;
                } 
            }
            return count;
            
        }
        public override string ToString()
        {
            return $"{Items.GetType()}";
        }

        //public override string ToString()
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    foreach (var item in this.Items)
        //    {
        //        stringBuilder.AppendLine($"{item.GetType().FullName}: {item}");
        //    }
        //    return stringBuilder.ToString().TrimEnd();
        //}
    }
}
