﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Event.Ex1
{
    public delegate void NameChangeEventHandler(object sender,NameChangeEventArgs args );
   

    public class Dispatcher
    {
        public event NameChangeEventHandler NameChange;

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; this.OnNameChange(new NameChangeEventArgs(value)); }
        }

        public void OnNameChange(NameChangeEventArgs args)
        {
            if (args != null)
            {
                this.NameChange(this, args);
            }
        }

    }
}
