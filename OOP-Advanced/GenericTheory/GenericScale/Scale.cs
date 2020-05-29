using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class Scale<T> where T : IComparable<T>
    {
        private T left;
        private T right;

        public Scale(T left , T right)
        {
            this.left = left;
            this.right = right;
        }

        //public int Left
        //{
        //    get { return left; }
        //    set { left = value; }
        //}
        

        //public int Right
        //{
        //    get { return right; }
        //    set { right = value; }
        //}

        public T GetHeavier()
        {
            var comparison = left.CompareTo(right);
            if (comparison > 0)
            {
                return left;
            }
            if (comparison < 0)
            {

                return right;
            }
          
            return default(T);
        }
    }
}
