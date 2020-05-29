using System;
using System.Collections.Generic;
using System.Text;

namespace KingsGambit
{
    public class King : IPerson
    {
        private IWroiter writer;
        public EventHandler UnderAttack;

        public King(string name , IWroiter writer)
        {
            this.Name = name;
            this.writer = writer;
        }

        public string Name { get; set; }

        public void OnUnderAttack()
        {
            this.writer.WriteLine($"King {this.Name} is under attack!");

            this.UnderAttack?.Invoke(this, new EventArgs());
        }
    }

}
