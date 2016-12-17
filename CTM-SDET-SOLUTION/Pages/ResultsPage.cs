using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace CTM_SDET_SOLUTION.Pages
{
    public class ResultsPage:BaseClass
    {
        public ResultsPage(IWebDriver driver) : base(driver)
        {
        }     

        public ResultsPage ValidateResultsPage(string yourResults)
        {
            var confirmPageText = Driver.FindElement(By.Id("header-containerheader-container"))
                .FindElement(By.TagName("ul"));
            IList<IWebElement> elements = new List<IWebElement>();
            elements.Add(confirmPageText);
            foreach (var element in elements)
            {
                if(element.Text.Contains(yourResults))
                Assert.IsTrue(element.Text.Contains(yourResults));
            }
            return this;
        }
    }
}
