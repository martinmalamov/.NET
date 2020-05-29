using _03BarracksFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace P03_BarraksWars.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

           Type type =  assembly.GetTypes().FirstOrDefault(t => t.Name.ToLower() == commandName + "command");

           IExecutable executable = (IExecutable) Activator.CreateInstance(type,new object[] {data,this.repository, this.unitFactory });

            return null;
        }
    }
}
