using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PWChallenge.HelperComponent;
using System;
using System.Collections.Generic;
using System.Text;

namespace PWChallenge
{
    [TestClass]
    public class TLogger
    {
        [TestMethod]
        public void TestLogger()
        {
            //var patternLayout = new PatternLayout();
            //patternLayout.ConversionPattern = "%date{dd-MM-yyyy-HH:mm:ss} [%class] [%level] [%method] - %message%newline";
            //patternLayout.ActivateOptions();

            //var consoleAppender = new ConsoleAppender()
            //{
            //    Name = "ConsoleAppender",
            //    Layout = patternLayout,
            //    Threshold = Level.Error
            //};
            //consoleAppender.ActivateOptions();

            //var fileAppender = new FileAppender()
            //{
            //    Name = "fileAppender",
            //    Layout = patternLayout,
            //    Threshold = Level.All,
            //    AppendToFile = true,
            //    File = "FileLogger.log"
            //};
            //fileAppender.ActivateOptions();

            //var rollingFileAppender = new RollingFileAppender()
            //{
            //    Name = "Backup Rolling File",
            //    AppendToFile = true,
            //    Layout = patternLayout,
            //    MaximumFileSize = "2MB",
            //    MaxSizeRollBackups = 10
            //};
            //rollingFileAppender.ActivateOptions();


            //BasicConfigurator.Configure(consoleAppender, fileAppender, rollingFileAppender);

        }

        [TestMethod]
        public void TestLog()
        {
            // ILog Logger = LogManager.GetLogger(typeof (TLogger));
            ILog Logger = LogHelper.GetXmlLogger(typeof(TLogger));
            for (var i = 0; i < 3000; i++)
            {
                Logger.Debug("Debug Information");
                Logger.Info("Info Information");
                Logger.Warn("Warning Information");
                Logger.Error("Error Information");
                Logger.Fatal("Fatal Information");
            }
         
        }

    }
}
