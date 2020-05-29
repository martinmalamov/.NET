using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public interface IHandler
    {
        void Handle(LogType type ,string message);
        void SetSuccessor(IHandler handler);
    }
}
