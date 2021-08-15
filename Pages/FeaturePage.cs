using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using PWChallenge.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace PWChallenge.Pages
{
    class FeaturePage
    {
        #region Elements

        private By FeatureLink = By.PartialLinkText("Featur");
        private By BookDemoFeatur = By.PartialLinkText("Book a De");

        #endregion

        #region Actions

        public void FeatureMenu()

        {
            Assert.IsTrue(ObjectRepository.Driver.FindElement(FeatureLink).Displayed);
            ObjectRepository.Driver.FindElement(FeatureLink).Click();
            
           
        }
        #endregion

        #region Book-a-Demo

        public void BookDemoFeature()
        {
            Assert.IsTrue(ObjectRepository.Driver.FindElement(BookDemoFeatur).Displayed);
            Assert.IsTrue(ObjectRepository.Driver.FindElement(BookDemoFeatur).Enabled);
        }

        #endregion
    }
}
