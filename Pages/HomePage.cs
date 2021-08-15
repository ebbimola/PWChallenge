using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using PWChallenge.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace PWChallenge.Pages
{
    public class HomePage
    {
        #region Elements

        private By HomePageHeading = By.ClassName("main-heading");
        private By BookDemoCheck = By.PartialLinkText("Book a De");

        #endregion

        #region Action

        public void AssertHeading()
        {
           Assert.IsTrue(ObjectRepository.Driver.FindElement(HomePageHeading).Displayed);
        }

        #endregion

        #region 
        public void DemoCheck()
        {
          Assert.IsTrue(ObjectRepository.Driver.FindElement(BookDemoCheck).Displayed);
          Assert.IsTrue(ObjectRepository.Driver.FindElement(BookDemoCheck).Enabled);
        }

        #endregion
    }
}
