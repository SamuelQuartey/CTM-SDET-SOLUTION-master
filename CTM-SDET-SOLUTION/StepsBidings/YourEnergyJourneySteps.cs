using CTM_SDET_SOLUTION.Pages;
using CTM_SDET_SOLUTION.TestHooks;
using System;
using TechTalk.SpecFlow;

namespace CTM_SDET_SOLUTION.StepsBidings
{
    [Binding]
    public sealed class YourEnergyJourneySteps
    {
        private readonly HelperClass _helperClass;
        private ResultsPage _resultsPage;
        public YourEnergyJourneySteps(HelperClass helperClass)
        {
            _helperClass = helperClass;
        }


        [Given(@"I have set Your Supplier Page Gas&ElectricityTab & YesCheckBox same supplier & Yes, I have my bill Tab")]
        public void GivenIHaveSetYourSupplierPageGasElectricityTabYesCheckBoxSameSupplierYesIHaveMyBillTab(Table table)
        {
            var postcode = table.Rows[0][0];
            var supplier = table.Rows[0][1];
            _helperClass.BaseClass.YourSupplierPage.Validate(postcode, supplier);
        }

        [Given(@"I have set Your Energy Page Electricity section with table information")]
        public void GivenIHaveSetYourEnergyPageElectricitySectionWithTableInformation(Table table)
        {
            var electricityTariff = table.Rows[0][0];
            var economy7Meter = table.Rows[0][1];
            var payment = table.Rows[0][2];
            var heatingSource = table.Rows[0][3];
            var kWhUsage = Convert.ToString(table.Rows[0][4]);
            var duration = table.Rows[0][5];
            _helperClass.BaseClass.YourEnergyPage
                .ValidateElectricity(electricityTariff, economy7Meter, payment, heatingSource, kWhUsage, duration);
        }

        [Given(@"I have set Your Energy Page Gas section with table information")]
        public void GivenIHaveSetYourEnergyPageGasSectionWithTableInformation(Table table)
        {
            var electricityTariff = table.Rows[0][0];
            var payment = table.Rows[0][2];
            var heatingSource = table.Rows[0][3];
            var kWhUsage = Convert.ToString(table.Rows[0][4]);
            var duration = table.Rows[0][5];
            _helperClass.BaseClass.YourEnergyPage.ValidateGas(electricityTariff, payment, heatingSource, kWhUsage, duration);
        }


        [When(@"I set Your Preferences page with table information, checked all checkbox & click GoToPrices button")]
        public void WhenISetYourPreferencesPageWithTableInformationCheckedAllCheckboxClickGoToPricesButton(Table table)
        {
            var electricityTariff = table.Rows[0][0];
            var payment = table.Rows[0][1];
            var email = table.Rows[0][2];
            _resultsPage = _helperClass.BaseClass.YourEnergyPage.GoToYourDetailsPage()
                .ValidateTariffsInterestedIn(electricityTariff)
                .ValidatePaymentsInterestedIn(payment, email).GoToResultsPage();
        }

        [Then(@"I am on Your Results page with message ""(.*)"" displayed")]
        public void ThenIAmOnYourResultsPageWithMessageDisplayed(string p0)
        {
            _resultsPage.ValidateResultsPage(p0);
        }
    }


}

