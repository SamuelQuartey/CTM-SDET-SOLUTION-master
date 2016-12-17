using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace CTM_SDET_SOLUTION.Pages
{
    public class YourSupplierPage:BaseClass
    {
        public YourSupplierPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.Id,Using = "your-postcode")]
        private IWebElement PostCodeImputField { get; set;}

        [FindsBy(How = How.Id, Using = "find-postcode")]
        private IWebElement FindPostCodeButton { get; set; }

        [FindsBy(How = How.Id, Using = "have-bill")]
        private IWebElement HaveBill { get; set; }

        [FindsBy(How = How.Id, Using = "no-bill")]
        private IWebElement HaveNoBill { get; set; }

        [FindsBy(How = How.Id, Using = "compare-what-both")]
        private IWebElement GasAndElectricity { get; set; }

        [FindsBy(How = How.Id, Using = "same-supplier-yes")]
        private IWebElement YesCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "same-supplier-no")]
        private IWebElement NocheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "compare-what-electricity")]
        private IWebElement Electricity { get; set; }

        [FindsBy(How = How.Id, Using = "economy-7-no")]
        private IWebElement Economy7NoCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "same-supplier-no")]
        private IWebElement Gas { get; set; }

        [FindsBy(How = How.ClassName, Using = "active-result")]
        private IWebElement SupplierType { get; set; }

        [FindsBy(How = How.Id, Using = "oto-your-supplier-details")]
        private IWebElement NextButton { get; set; }

        //For Both Gas and Electricity Scenarios 
        public YourEnergyPage Validate(string postCode, string supplier)
        {
            PostCodeImputField.SendKeys(postCode);
            FindPostCodeButton.Click();
            Thread.Sleep(TimeSpan.FromHours(10));
            HaveBill.Click();
            GasAndElectricity.Click();
            //Supplier Radio Buttons Only Scenarios
            var supplierButtons = Driver.FindElement(By.ClassName("radio-buttons"));
            var buttons = new SelectElement(supplierButtons);
            buttons.SelectByText(supplier);
            NextButton.Click();
            return new YourEnergyPage(Driver);
        }

        //For Gas Only 
        public YourEnergyPage ValidateGass(string postCode, string supplier)
        {
            HaveNoBill.Click();
            Gas.Click();
            PostCodeImputField.SendKeys(postCode);
            FindPostCodeButton.Click();
            Thread.Sleep(TimeSpan.FromHours(10));
            var selectDropdown = Driver.FindElement(By.ClassName("chosen-results"));
            var dropDown = new SelectElement(selectDropdown);
            dropDown.SelectByText(supplier);
            NextButton.Click();
            return new YourEnergyPage(Driver);
        }

        //FOR ELECTRICITY ONLY NO BILL
        public YourEnergyPage ValidateElectricity(string postCode, string supplier)
        {
            HaveNoBill.Click();
            Electricity.Click();
            PostCodeImputField.SendKeys(postCode);
            FindPostCodeButton.Click();
            Thread.Sleep(TimeSpan.FromHours(10));
            var selectDropdown = Driver.FindElement(By.ClassName("chosen-results"));
            var dropDown = new SelectElement(selectDropdown);
            dropDown.SelectByText(supplier);
            NextButton.Click();
            return new YourEnergyPage(Driver);
        }

    }
}
