namespace SolidPrincipalsTheory
{
    using SolidPrincipalsTheory.Appenders;
    using SolidPrincipalsTheory.Appenders.Contracts;
    using SolidPrincipalsTheory.Layouts;
    using SolidPrincipalsTheory.Layouts.Contracts;
    using SolidPrincipalsTheory.Loggers;
    using SolidPrincipalsTheory.Loggers.Contracts;
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var simplelayout = new simplelayout();
            var consoleappender = new consoleappender(simplelayout);
            //var file = new logfile();
            var fileappender = new fileappender(simplelayout);
            var logger = new logger(fileappender);



            logger.error("3/26/2015 2:08:11 pm", "error parsing json. ");
            logger.info("3/26/2015 2:08:11 pm", "user pesho successfully registered");
            var simpleLayout = new SimpleLayout();
            var consoleAppender = new ConsoleAppender(simpleLayout);
            
            var fileAppender = new FileAppender(simpleLayout);
            var logger = new Logger( fileAppender);
            logger.Error(" 3 / 26 / 2015 2:08:11 PM ", " Error parsing JSON.");
            logger.Info("3 / 26 / 2015 2:08:11 PM "," User Pesho successfully registered.");

        }
    }
}
