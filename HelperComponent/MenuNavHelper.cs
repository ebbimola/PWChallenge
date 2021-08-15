using OpenQA.Selenium;
using PWChallenge.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace PWChallenge.HelperComponent
{
    class MenuNavHelper
    {
        public static void NavigateToUrl(string Url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(Url);
            
        }
    }
}
