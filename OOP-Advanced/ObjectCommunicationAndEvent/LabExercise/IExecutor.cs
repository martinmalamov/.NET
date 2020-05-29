using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
  public  interface IExecutor
    {
        void ExecuteCommand(ICommand command);
    }
}
