﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TupleEx10
{
   public class TuplePerson 
    {
        private string firstName;
        private string lastName;
        private string adress;

        private List<string> person;

        public TuplePerson(List<string> person)
        {
            Person = person;
        }

        public TuplePerson(string name, string lastName , string adress)
        {
            this.FirstName = name;
            this.LastName = lastName;
            this.Adress = adress;   
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }


        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public List<string> Person { get => person; set => person = value; }

        public override  string ToString()
        {
            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append(FirstName).Append(LastName).AppendLine(Adress);
            //return stringBuilder.ToString();
           return $"{FirstName} {LastName} -> {Adress}";
        }
    }
}
