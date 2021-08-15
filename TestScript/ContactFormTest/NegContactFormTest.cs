
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PWChallenge.ComponentHelper;
using PWChallenge.HelperComponent;
using PWChallenge.Settings;
using System;
using System.Collections.Generic;
using System.Threading;

namespace PWChallenge
{
    [TestClass]
    [TestCategory("ContactFormNegativeTest")]
    public class TestContactForm
    {
        [TestInitialize]
        public void OpenBrowser()
        {
            string pw = "https://www.perfectward.com";
            MenuNavHelper.NavigateToUrl(pw);
        }

        [TestMethod]
        [Description("fail form submission and catch validation error")]
        public void FailContactFormSubmit()
        {

            IWebElement ContactLink = ObjectRepository.Driver.FindElement(By.PartialLinkText("Conta"));
            ContactLink.Click();
            Assert.IsTrue(ObjectRepository.Driver.FindElement(By.XPath("//h3[contains(text(),'Have a question?')]")).Enabled);

             var userName = ObjectRepository.Driver.FindElement(By.XPath("//input[@id='form-input-firstName']"));
             userName.SendKeys("Joey");

             var lastName = ObjectRepository.Driver.FindElement(By.XPath("//input[@id='form-input-lastName']"));
             lastName.SendKeys("Blogings");

             var email = ObjectRepository.Driver.FindElement(By.XPath("//input[@id='form-input-email']"));
             email.SendKeys("Joey.Blogings@JB.com");

             var phone = ObjectRepository.Driver.FindElement(By.XPath("//input[@id='form-input-telephone']"));
             phone.SendKeys("07200012345");

            var roless = ObjectRepository.Driver.FindElement(By.CssSelector("#form-input-roles"));
            var selectRoles = new SelectElement(roless);
            selectRoles.SelectByText("CTO/CIO");

            var sectors = ObjectRepository.Driver.FindElement(By.CssSelector("#form-input-sectors"));
            var selectSectors = new SelectElement(sectors);
            selectSectors.SelectByText("Other");

            var org = ObjectRepository.Driver.FindElement(By.CssSelector("#form-input-companyName"));
            org.SendKeys("JB Limited");

            var referral = ObjectRepository.Driver.FindElement(By.CssSelector("#form-input-referralChannel"));
            var selectReferral = new SelectElement(referral);
            selectReferral.SelectByText("Referral");
            
            var msg = ObjectRepository.Driver.FindElement(By.CssSelector("#form-input-message"));
            msg.SendKeys("");

            var gdpr = GenericHelper.GetElement(By.XPath("// input[@id='form-input-gdpr']"));
            gdpr.Click();

            //Is button disabled
            ButtonHelper.ClickButton(By.XPath("//butto[@name='form_page_submit' and @type='submit]"));

           //Assert that form validated with an error message
            String error_msg = GenericHelper.GetElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/form[1]/div[1]/p[1]")).Text;
            String exp_error = "Sorry, there was an error submitting the form. Please try again.";
            Assert.AreEqual(error_msg, exp_error);

                        
        }
    }
}

