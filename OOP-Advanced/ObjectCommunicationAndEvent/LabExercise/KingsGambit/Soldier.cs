using System;
using System.Collections.Generic;
using System.Text;

namespace KingsGambit
{
    public abstract class Soldier : IPerson
    {
        public Soldier(string name , IWroiter writer)
        {
            this.Name = name;
            this.Writer = writer;
        }

        public  string Name { get; set; }

        protected IWroiter Writer { get; set; }

        public abstract void KingUnderAttack(object sender , EventArgs e);

    }
}
