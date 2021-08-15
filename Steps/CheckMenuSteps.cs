using PWChallenge.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PWChallenge.Steps
{
    [Binding]
    public sealed class CheckMenuSteps
    {
       /* private HomePage hpage;
        private IpcPage Ipage;
        private FeaturesPage fPage;
        private SolutionsPage sPage;
        private ResourcesPage rPage;
        private NewsPage nPage;
        private CasePage cPage;
        private WebinarPage wPage;
        private ContactPage cPage; */

        #region Given

        [Given(@"the Perfedct Ward home-page is displayed")]
        public void GivenThePerfedctWardHome_PageIsDisplayed()
        {
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
        }

        #endregion




    }
}
