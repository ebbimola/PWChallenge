
using OpenQA.Selenium;
using PWChallenge.Interfaces;

namespace PWChallenge.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }

    }
}
