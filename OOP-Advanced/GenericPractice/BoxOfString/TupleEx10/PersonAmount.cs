﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TupleEx10
{
   public class PersonAmount
    {
        private int amount;
        private string name;

        public PersonAmount(int amount, string name)
        {
            this.Amount = amount;
            this.Name = name;
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return $"{Name} -> {Amount}";
        }
    }
}
