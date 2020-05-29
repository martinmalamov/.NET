using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
   public class ListyIterator<T>  : IEnumerable<T>
    {
        private T[] elements;
        private int index;

        public ListyIterator(T[] elements)
        {
            this.elements = elements;
            this.index = 0;
        }

        public bool Move()
        {
            if (this.index < this.elements.Length - 1)
            {
                this.index++;
                return true;
            }

            return false;
        }

        public bool HasNexnt()
        {
            return this.index < this.elements.Length - 1 ? true : false;
        }

        public void Print()
        {
            if (this.elements.Length > 0 )
            {
                Console.WriteLine(this.elements[this.index]);
                return;
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)elements).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return ((IEnumerable<T>)elements).GetEnumerator();
        }

        public void PrintAll()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                T index2 = elements[i];
                Console.Write(index2 +  " ");
            }
            Console.WriteLine();
            //foreach (var item in this.elements)
            //{
            //    Console.Write(string.Join(" ", elements));
            //}
        }
    }
}
