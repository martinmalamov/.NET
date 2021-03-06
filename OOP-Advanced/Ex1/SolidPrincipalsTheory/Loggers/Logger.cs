﻿using SolidPrincipalsTheory.Appenders.Contracts;
using SolidPrincipalsTheory.Loggers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincipalsTheory.Loggers
{
    public class Logger : ILogger
    {
        private readonly IAppender appender;

        public Logger(IAppender appender)
        {
            this.appender = appender;
        }

        public void Error(string dateTime, string errorMessage)
        {
            this.appender.Append(dateTime, "Error", errorMessage );
        }

        public void Info(string dateTime, string infoMessage)
        {
            this.appender.Append(dateTime, "Info",infoMessage);
        }
    }
}
