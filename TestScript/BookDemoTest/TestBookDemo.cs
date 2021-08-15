using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PWChallenge.HelperComponent;
using PWChallenge.Settings;

namespace PWChallenge
{
    [TestClass]
    [TestCategory("CheckForBookaDemo")]
    public class TestBookDemo
    {
        
        [TestInitialize]
        public void OpenBrowser()
        {
            string pw = "https://www.perfectward.com";
            MenuNavHelper.NavigateToUrl(pw);
        }

        [TestMethod]
        [Description("Test that Book-a-Demo is visible and enabled on home page")]
        public void TestBdHome()
        {
            //Am I Home?
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.ClassName("main-heading")).Displayed);
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Enabled);
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Displayed);
        }

        [TestMethod]
        [Description("Test that Book-a-Demo is visible and enabled on IPC page")]
        public void TestBdIpc()
        {
            IWebElement CovidLink = ObjectRepository.Driver.FindElement(By.PartialLinkText("IPC"));
            CovidLink.Click();
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Enabled);
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Displayed);
        }


        [TestMethod]
        [Description("Test that Book-a-Demo is visible and enabled on Features page")]
        public void TestBdFeatures()
        {
            IWebElement FeaturesLink = ObjectRepository.Driver.FindElement(By.PartialLinkText("Features"));
            FeaturesLink.Click();
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Enabled);
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Displayed);
        }

        [TestMethod]
        [Description("Test that Book-a-Demo is visible and enabled on Our Solutions page")]
        public void TestBdSolutions()
        {
            IWebElement SolutionLink = ObjectRepository.Driver.FindElement(By.PartialLinkText("Our Soluti"));
            SolutionLink.Click();
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Enabled);
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Displayed);
        }

        [TestMethod]
        [Description("Test that Book-a-Demo is visible and enabled on Resources page")]
        public void TestBdResource()
        {
            IWebElement ResourceLink = ObjectRepository.Driver.FindElement(By.PartialLinkText("Resourc"));
            ResourceLink.Click();
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Enabled);
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Displayed);
        }

        [Ignore]
        [TestMethod]
        [Description("Test that Book-a-Demo is visible and enabled on News page")]
        public void TestBdNews()
        {
            //Select News menu

            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Enabled);
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Displayed);

        }

        [Ignore]
        [TestMethod]
        [Description("Test that Book-a-Demo is visible and enabled on Case Studies page")]
        public void TestBdCs()
        {
            //Select Case Studies  Menu

            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Enabled);
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Displayed);

        }

        [Ignore]
        [TestMethod]
        [Description("Test that Book-a-Demo is visible and enabled on Webinar page")]
        public void TestBdWebinar()
        {
           //Select Webinar menu
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Enabled);
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Displayed);

        }

        [TestMethod]
        [Description("Test that Book-a-Demo is visible and enabled on Contact page")]
        public void TestBdContact()
        {
            IWebElement ContactLink = ObjectRepository.Driver.FindElement(By.PartialLinkText("Contact"));
            ContactLink.Click();
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Enabled);
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.LinkText("Book a Demo")).Displayed);

        }
    }
}