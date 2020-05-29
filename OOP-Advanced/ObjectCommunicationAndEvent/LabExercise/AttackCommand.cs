using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class AttackCommand : ICommand
    {


        //public void Execute()
        //{
        //    throw new NotImplementedException();
        //}

        //public void ExecuteCommand(ICommand command)
        //{
        //    throw new NotImplementedException();
        //}

        private IAttacker attacker;
        public AttackCommand(IAttacker attacker)
        {
            this.attacker = attacker;
        }

        public void Execute()
        {
            this.attacker.Attack();
        }
    }
}
