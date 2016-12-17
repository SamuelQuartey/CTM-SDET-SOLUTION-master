using CTM_SDET_SOLUTION.BrowserSetup;
using TechTalk.SpecFlow;

namespace CTM_SDET_SOLUTION.TestHooks
{
    [Binding]
    public sealed class StepsHook
    {
        private readonly Browser _browser;

        public StepsHook(Browser browser)
        {
            _browser = browser;
        }

       
        [BeforeScenario]
        public void OpenBrowser()
        {
            ScenarioContext.Current["driver"] = _browser.LunchBrowser();
        }

        [AfterScenario]
        public void QuitBrowser()
        {
            _browser.CloseBrowser();
        }

    }
}
