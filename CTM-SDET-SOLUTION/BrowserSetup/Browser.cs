using System;
using CTM_SDET_SOLUTION.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace CTM_SDET_SOLUTION.BrowserSetup
{
    public class Browser
    {
        private IWebDriver _driver;
        public IWebDriver LunchBrowser()
        {
            var baseUrl = Application.Default.BaseUrl;
            var browser = Application.Default.browser;

            if (browser.Contains("chrome"))_driver = new ChromeDriver();
            if (browser.Contains("ie"))_driver = new InternetExplorerDriver();
           
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(baseUrl);
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            return _driver;
        }

        public void CloseBrowser()
        {
            if (_driver != null) _driver.Quit();
        }
    }
}
