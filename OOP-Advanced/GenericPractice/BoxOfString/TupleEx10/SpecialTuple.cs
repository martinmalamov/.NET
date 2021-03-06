﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TupleEx10
{
    public class SpecialTuple<T1, T2, T3>
    {
        public SpecialTuple(T1 item1, T2 item2,T3 item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.DrunkOrNot = item3;
        }

        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
       
        

        private T3 drunkOrNot;
        public T3 DrunkOrNot
        {
            get { return drunkOrNot; }
           
            set
            {
                drunkOrNot = value;
            }
            
        }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {DrunkOrNot}";
        }
    }
}
