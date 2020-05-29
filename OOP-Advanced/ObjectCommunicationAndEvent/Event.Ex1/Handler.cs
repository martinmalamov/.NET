using System;
using System.Collections.Generic;
using System.Text;

namespace Event.Ex1
{
   public class Handler 
    {
        private IWriter writer;

        public Handler(IWriter writer)
        {
            this.writer = writer;
        }

        public void OnDispatcherNameChange(object sunder , NameChangeEventArgs args)
        {
            this.writer.WriteLine($"Dispatcher's name change to {args.Name}.");
        }

    }
}
