using System;
using System.Collections.Generic;
using System.Text;

namespace KingsGambit
{
    public class RoyalGuard : Soldier
    {
        public RoyalGuard(string name, IWroiter writer) : base(name, writer)
        {
        }

        public override void KingUnderAttack(object sender, EventArgs e)
        {
            this.Writer.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
