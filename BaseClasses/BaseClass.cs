
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using PWChallenge.Configuration;
using PWChallenge.CustomException;
using PWChallenge.Settings;
using PWChallenge.HelperComponent;
using System;

namespace PWChallenge.BaseClasses
{
    [TestClass]
    public class BaseClass
    {
        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }


        [AssemblyInitialize]
        public static void InitWebdriver(TestContext tc)
        {
            
            ObjectRepository.Driver = GetChromeDriver();

            /*
            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Firefox:
                    ObjectRepository.Driver = GetFirefoxDriver();
                    break;

                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;

                default:
                    throw new DriverNotFound("Driver Not Found : " + ObjectRepository.Config.GetBrowser().ToString()); 
            }
            */

            ObjectRepository.Driver.Manage()
                                   .Timeouts();
            //.SetPageLoadTimeout(TimeSpan.FromSeconds(ObjectRepository.Config.GetPageLoadTimeOut()));
            ObjectRepository.Driver.Manage()
                                   .Timeouts();//.ImplicitWait(TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut()));
            BrowserHelper.BrowserMaximize();
        }

        [AssemblyCleanup]
        public static void TearDown()
        {
            if (ObjectRepository.Driver != null)
            {
               ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }
    }
}
