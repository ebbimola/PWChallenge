using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using PWChallenge.HelperComponent;
using PWChallenge.Settings;
using System;

namespace PWChallenge
{
    [TestClass]
    [TestCategory("HighLevelMenu")]
    public class TestHighLevelMenu
    {
        

        [TestInitialize]
        public void OpenBrowser()
        {
            string pw = "https://www.perfectward.com";
            MenuNavHelper.NavigateToUrl(pw);
        }


        [TestMethod]
        [Description("Test that Homepage loads successfully")]
        public void HomeMenuTest()
        {
          
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.ClassName("main-heading")).Displayed);
            string HomeTitle = ObjectRepository.Driver.Title;
            Assert.AreEqual(HomeTitle, "Quality Improvement App | Perfect Ward");
        }


        [TestMethod]
        [Description("Test that IPC menu is accessible ")]
        public void IPCMenuTest()
        {

            IWebElement CovidLink = ObjectRepository.Driver.FindElement(By.PartialLinkText("IPC"));
            Assert.IsNotNull(CovidLink);
            CovidLink.Click();
        }

        [TestMethod]
        [Description("Test that Features menu is accessible")]
        public void FeaturesMenuTest()
        {
            IWebElement FeatureLink = ObjectRepository.Driver.FindElement(By.PartialLinkText("Featur"));
            Assert.IsNotNull(FeatureLink);
            FeatureLink.Click();
        }

        [TestMethod]
        [Description("Test that Our Solutions menu is accessible")]
        public void SolutionsMenuTest()
        {
            IWebElement SolutionLink = ObjectRepository.Driver.FindElement(By.PartialLinkText("Our Soluti"));
            Assert.IsNotNull(SolutionLink);
            SolutionLink.Click();
        }

        [TestMethod]
        [Description("Test that Resources menu is accessible")]
        public void ResourcesMenuTest()
        {
            IWebElement ResourceLink = ObjectRepository.Driver.FindElement(By.PartialLinkText("Resourc"));
            Assert.IsNotNull(ResourceLink);
            ResourceLink.Click();
        }

        [Ignore]
        [TestMethod]
        [Description("Test that News menu is accessible")]
        public void NewsMenuTest()
        {
                //SelectElement Resourcedropdown = new SelectElement (ObjectRepository.Driver.FindElement(By.ClassName("dropdown-default")));
                //Resourcedropdown.SelectByText("News");
        }

        [Ignore]
        [TestMethod]
        [Description("Test that Case Studies menu is accessible")]
        public void CsMenuTest()
        {

            //Refectoring
        
        }

        [Ignore]
        [TestMethod]
        [Description("Test that Webinar menu is accessible")]
        public void WebinarMenuTest()
        {
            //Refectoring
        }

        [TestMethod]
        [Description("Test that Contact menu is accessible")]
        public void ContactMenuTest()
        {

            IWebElement ContactLink = ObjectRepository.Driver.FindElement(By.PartialLinkText("Contact"));
            Assert.IsNotNull(ContactLink);
            ContactLink.Click();
        }

    }
}
