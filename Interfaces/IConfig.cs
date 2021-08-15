using System;

using PWChallenge.Configuration;

namespace PWChallenge.Interfaces
{
    public interface IConfig
    {
        BrowserType? GetBrowser();
        string GetWebsite();
        int GetPageLoadTimeOut();
        int GetElementLoadTimeOut();
    }
}
