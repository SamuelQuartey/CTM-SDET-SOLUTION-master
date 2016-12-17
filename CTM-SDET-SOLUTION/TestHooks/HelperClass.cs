using CTM_SDET_SOLUTION.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace CTM_SDET_SOLUTION.TestHooks
{
    public class HelperClass
    {
        private BaseClass _baseClass;
        public BaseClass BaseClass
        {
            get
            {
                _baseClass = new BaseClass((IWebDriver) ScenarioContext.Current["driver"]);
                return _baseClass;
            }
        }
    }
}
