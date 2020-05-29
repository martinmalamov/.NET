using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincipalsTheory.Appenders.Contracts
{
    public interface IAppender
    {
        void Append(string dateType, string errorLevel, string message);
    }
}
