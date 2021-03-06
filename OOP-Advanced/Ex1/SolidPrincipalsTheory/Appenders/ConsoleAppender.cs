﻿
namespace SolidPrincipalsTheory.Appenders
{
    using System;
    using SolidPrincipalsTheory.Appenders.Contracts;
    using SolidPrincipalsTheory.Layouts.Contracts;

    class ConsoleAppender : IAppender
    {
        private readonly ILayout layout;

        public ConsoleAppender(ILayout layout)
        {
            this.layout = layout;
        }

        public void Append(string dateType,string errorLevel,string message)
        {
            Console.WriteLine(string.Format(this.layout.Format,dateType,errorLevel,message));
        }
    }
}
