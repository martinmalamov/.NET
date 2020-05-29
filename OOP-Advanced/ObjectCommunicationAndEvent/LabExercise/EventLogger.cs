using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class EventLogger : Logger
    {
       
        public override void Handle(LogType type, string message)
        {
            switch (type)
            {
                //case LogType.ATTACK:
                //    break;
                //case LogType.MAGIC:
                //    break;
                //case LogType.TARGET:
                //    break;
                //case LogType.ERROR:
                //    break;
                case LogType.EVENT:
                    Console.WriteLine(type.ToString() + ": " + message);
                    break;
                
            }
            this.PassToSuccessor(type,message);
        }
    }
}
