using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using System;
using System.Collections.Generic;
using System.Text;

namespace PWChallenge.HelperComponent
{
    public class LogHelper
    {
        private static ILog _logger;
        private static ILog _xmlLogger;
        private static ConsoleAppender _consoleAppender;
        private static FileAppender _fileAppender;
        private static RollingFileAppender _rollingFileAppender;
        private static string _layout = "%date{dd-MM-yyyy-HH:mm:ss} [%class] [%level] [%method] - %message%newline";

        public static string Layout
        {
            set { _layout = value; }
        }

        private static PatternLayout GetPatternLayout()
        {
            var patternLayout = new PatternLayout()
            {
                ConversionPattern = _layout
            };
            patternLayout.ActivateOptions();
            return patternLayout;

        }

        private static ConsoleAppender GetConsoleAppender()
        {
            var consoleAppender = new ConsoleAppender()
            {
                Name = "ConsoleAppender",
                Layout = GetPatternLayout(),
                Threshold = Level.Error
            };
            consoleAppender.ActivateOptions();
            return consoleAppender;
        }

        private static FileAppender GetFileAppender()
        {
            var fileAppender = new FileAppender()
            {
                Name = "fileAppender",
                Layout = GetPatternLayout(),
                Threshold = Level.All,
                AppendToFile = true,
                File = "FileLogger.log"
            };
            fileAppender.ActivateOptions();
            return fileAppender;
        }

        private static RollingFileAppender GetRollingFileAppender()
        {
            var rollingFileAppender = new RollingFileAppender()
            {
                Name = "Backup Rolling File",
                AppendToFile = true,
                Layout = GetPatternLayout(),
                MaximumFileSize = "2MB",
                MaxSizeRollBackups = 10
            };
            rollingFileAppender.ActivateOptions();
            return rollingFileAppender;
        }

        public static ILog GetLogger(Type type)
        {
            if (_consoleAppender == null)
                _consoleAppender = GetConsoleAppender();

            if (_fileAppender == null)
                _fileAppender = GetFileAppender();

            if (_rollingFileAppender == null)
                _rollingFileAppender = GetRollingFileAppender();

            if (_logger != null)
                return _logger;

            BasicConfigurator.Configure(_consoleAppender, _fileAppender, _rollingFileAppender);
            _logger = LogManager.GetLogger(type);
            return _logger;
        }

        public static ILog GetXmlLogger(Type type)
        {
            if (_xmlLogger != null)
                return _xmlLogger;

            XmlConfigurator.Configure();
            _xmlLogger = LogManager.GetLogger(type);
            return _xmlLogger;
        }
    }
}
