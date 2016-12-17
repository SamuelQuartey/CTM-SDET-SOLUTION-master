using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace CTM_SDET_SOLUTION.Pages
{
    public class YourEnergyPage:BaseClass
    {
        public YourEnergyPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.Id, Using = "gas_current_spend_period_chosen")]
        private IWebElement EnergySpendPeriod { get; set; }

        [FindsBy(How = How.Id, Using = "economy-7-yes")]
        private IWebElement Economy7YesCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "electricity-main-heating-yes")]
        private IWebElement MainSourchOfHeatingYesCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "economy-7-no")]
        private IWebElement Economy7NoCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "electricity-main-heating-no")]
        private IWebElement MainSourchOfHeatingNoCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "electricity-usage")]
        private IWebElement UsageInputField { get; set; }

        [FindsBy(How = How.Id, Using = "kwhSpend")]
        private IWebElement KWhCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "chosen-results")]
        private IWebElement ChosenResults { get; set; }

        [FindsBy(How = How.Id, Using = "goto-your-energy")]
        private IWebElement GoToEnergyNextButton { get; set; }

        [FindsBy(How = How.Id, Using = "gas-current-spend")]
        private IWebElement EnergySpend { get; set; }

        [FindsBy(How = How.Id, Using = "elec-current-spend-question")]
        private IWebElement DontKnowCheckBox { get; set; }

        public YourEnergyPage ValidateElectricity(string tariff, string economyMeter, string payment, string heatingSource, string usage, string usageTime)
        {
            var selectTariff = Driver.FindElement(By.ClassName("chosen-results"));
            var selectOption = new SelectElement(selectTariff);
            selectOption.SelectByText(tariff);

            if (Economy7YesCheckBox.Text.Contains(economyMeter)) Economy7YesCheckBox.Click();
            if (Economy7NoCheckBox.Text.Contains(economyMeter)) Economy7NoCheckBox.Click();

            var paymentOption = Driver.FindElement(By.Id("electricity_payment_method_dropdown_link_chosen"));
            var selectPayment = new SelectElement(paymentOption);
            selectPayment.SelectByText(payment);

            if (MainSourchOfHeatingYesCheckBox.Text.Contains(heatingSource)) MainSourchOfHeatingYesCheckBox = null;
            if (MainSourchOfHeatingNoCheckBox.Text.Contains(heatingSource)) MainSourchOfHeatingNoCheckBox.Click();

            KWhCheckBox.Click();
            // use "Annually" only for now, other logic not implemented yet
            UsageInputField.SendKeys(usage);
            var usagePeriod = new SelectElement(ChosenResults);
            usagePeriod.SelectByText(usageTime);
            return this;   
        }

        public YourEnergyPage ValidateGas(string tariff, string payment, string heatingSource, string usage, string usageTime)
        {
            var selectTariff = Driver.FindElement(By.ClassName("chosen-results"));
            var selectOption = new SelectElement(selectTariff);
            selectOption.SelectByText(tariff);

            var paymentOption = Driver.FindElement(By.Id("electricity_payment_method_dropdown_link_chosen"));
            var selectPayment = new SelectElement(paymentOption);
            selectPayment.SelectByText(payment);

            if (MainSourchOfHeatingYesCheckBox.Text.Contains(heatingSource)) MainSourchOfHeatingYesCheckBox = null;
            if (MainSourchOfHeatingNoCheckBox.Text.Contains(heatingSource)) MainSourchOfHeatingNoCheckBox.Click();

            // use "Annually" only for now, other logic not implemented yet
            KWhCheckBox.Click();
            UsageInputField.SendKeys(usage);
            var usagePeriod = new SelectElement(ChosenResults);
            usagePeriod.SelectByText(usageTime);
            return this;
        }

        //FOR GAS WITH NO BILL
        public DetailsPage ValidateHaveNoBillGas(string value, string period)
        {
            EnergySpend.SendKeys(value);
            var selectEnergyPeriod = new SelectElement(EnergySpendPeriod);
            selectEnergyPeriod.SelectByText(period);
            GoToEnergyNextButton.Click();
            return new DetailsPage(Driver);
        }

        //FOR ELECTRICITY WITH NO BIL
        public DetailsPage ValidateHaveNoBillElectricityIDontKnow()
        {
            Economy7NoCheckBox.Click();
            DontKnowCheckBox.Click();
            GoToEnergyNextButton.Click();
            return new DetailsPage(Driver);
        }

        //FOR ENERGY USAGE WORKOUT 
        public YourEnergyPage ElectricityEnergyUsage(string homeSize, string numberOfPeople, string sourceOfHeating, string temperature, string insulation, string cookingEnergySource, string timesAtHome)
        {
            var homeSizeElement = Driver.FindElement(By.Id("how-big-is-your-home"))
                .FindElement(By.ClassName("radio-buttons"));
            var selectEhomeSize = new SelectElement(homeSizeElement);
            selectEhomeSize.SelectByText(homeSize);

            var numberOfPeopleAtHome = Driver.FindElement(By.Id("number-of-occupants"))
                .FindElement(By.ClassName("radio-buttons"));
            var selectnumberOfPeople = new SelectElement(numberOfPeopleAtHome);
            selectnumberOfPeople.SelectByText(numberOfPeople);

            var heatingSource = Driver.FindElement(By.Id("main-heating-source"))
                .FindElement(By.ClassName("radio-buttons"));
            var selectHeating = new SelectElement(heatingSource);
            selectHeating.SelectByText(sourceOfHeating);

            var homeTemperature = Driver.FindElement(By.Id("heating-usage"))
                .FindElement(By.ClassName("radio-buttons"));
            var selectHomeTemperature = new SelectElement(homeTemperature);
            selectHomeTemperature.SelectByText(temperature);

            var homeinsulation = Driver.FindElement(By.Id("house-insulation"))
                .FindElement(By.ClassName("radio-buttons"));
            var selectHomeInsulation = new SelectElement(homeinsulation);
            selectHomeInsulation.SelectByText(insulation);

            var homecookingEnergySource = Driver.FindElement(By.Id("main-cooking-source"))
                .FindElement(By.ClassName("radio-buttons"));
            var selectCookingSourceEnergy = new SelectElement(homecookingEnergySource);
            selectCookingSourceEnergy.SelectByText(cookingEnergySource);

            var homeTmes = Driver.FindElement(By.Id("house-occupied"))
                .FindElement(By.ClassName("radio-buttons"));
            var selecttimesAtHome = new SelectElement(homeTmes);
            selecttimesAtHome.SelectByText(timesAtHome);
            return this;
        }

        public DetailsPage GoToYourDetailsPage()
        {
            GoToEnergyNextButton.Click();
            return new DetailsPage(Driver);
        }
    }
}
