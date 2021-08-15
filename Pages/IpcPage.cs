using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using PWChallenge.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace PWChallenge.Pages
{
   public class IpcPage
    {
        #region Elements

        private By IpcLink = By.PartialLinkText("IPC");
        private By BookDemoCheckIpc = By.PartialLinkText("Book a De");

        #endregion

        #region Actions
        public void CheckIpcLink()
        {
            Assert.IsTrue(ObjectRepository.Driver.FindElement(IpcLink).Displayed);
            ObjectRepository.Driver.FindElement(IpcLink).Click();
        }
        #endregion

        public void BookDemoIpc()
        {
            Assert.IsTrue(ObjectRepository.Driver.FindElement(BookDemoCheckIpc).Displayed);
            Assert.IsTrue(ObjectRepository.Driver.FindElement(BookDemoCheckIpc).Enabled);
        }
    }
}
