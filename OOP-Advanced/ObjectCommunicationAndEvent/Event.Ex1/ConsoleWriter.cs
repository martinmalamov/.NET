﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Event.Ex1
{
  public  class ConsoleWriter : IWriter
    {
        public void WriteLine(string line) => Console.WriteLine(line);
    }
}
