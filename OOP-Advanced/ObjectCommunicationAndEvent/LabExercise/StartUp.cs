namespace Heroes
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Logger combatLog = new CombatLogger();
            Logger eventLog = new EventLogger();

            combatLog.SetSuccessor(eventLog);

            var warrior = new Warrior("gosho",10,combatLog);
            var dragon = new Dragon("Petar",100,25,combatLog);

            IExecutor executor = new CommandExecutor();
            ICommand command = new TargetCommand(warrior,dragon);
            ICommand command2 = new AttackCommand(warrior);
            
        }
    }
}
