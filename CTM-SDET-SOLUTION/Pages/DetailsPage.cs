using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CTM_SDET_SOLUTION.Pages
{
    public class DetailsPage:BaseClass
    {
        public DetailsPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement EmailAddressField { get; set; }

        [FindsBy(How = How.Id, Using = "marketingPreference")]
        private IWebElement MarketingCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "TnC")]
        private IWebElement ConfirmTnCsCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "email-submit")]
        private IWebElement GoToPricesButton { get; set; }


        public DetailsPage ValidateTariffsInterestedIn(string tariff)
        {
            var mainTariffs = Driver.FindElement(By.Id("tariff-selection-question")).FindElement(By.ClassName("what-tariff"));
            foreach (var element in mainTariffs.FindElements(By.LinkText(tariff)))
            {
                if (element.Text.Contains(tariff)) element.Click(); break;
            }
            return this;
        }

        public DetailsPage ValidatePaymentsInterestedIn(string paymentsType, string email)
        {
            var mainPayments = Driver.FindElement(By.Id("payment-selection-question")).FindElement(By.ClassName("what-payment-type"));
            foreach (var element in mainPayments.FindElements(By.LinkText(paymentsType)))
            {
                if (element.Text.Contains(paymentsType)) element.Click(); break;
            }
            EmailAddressField.SendKeys(email);
            MarketingCheckBox.Click();
            ConfirmTnCsCheckBox.Click();
            return this;
        }

        public ResultsPage GoToResultsPage()
        {
            GoToPricesButton.Click();
            return new ResultsPage(Driver);
        }

    }
}
