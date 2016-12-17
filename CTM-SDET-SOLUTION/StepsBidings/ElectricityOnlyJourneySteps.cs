using CTM_SDET_SOLUTION.Pages;
using CTM_SDET_SOLUTION.TestHooks;
using TechTalk.SpecFlow;

namespace CTM_SDET_SOLUTION.StepsBidings
{
    [Binding]
    public sealed class ElectricityOnlyJourneySteps
    {
        private HelperClass _helperClass;
        private DetailsPage _detailsPage;
        public ElectricityOnlyJourneySteps(HelperClass helper)
        {
            _helperClass = helper;
        }

        [Given(@"I have set Your Supplier Page ElectricityTab & Yes, I have no bill Tab")]
        public void GivenIHaveSetYourSupplierPageElectricityTabYesIHaveNoBillTab(Table table)
        {
            var postcode = table.Rows[0][0];
            var supplier = table.Rows[0][1];
            _helperClass.BaseClass.YourSupplierPage.ValidateElectricity(postcode, supplier);
        }

        [Given(@"Your Energy Page Electricity Only I don't know checkbox ticked")]
        public void GivenYourEnergyPageElectricityOnlyIDonTKnowCheckboxTicked()
        {
            _helperClass.BaseClass.YourEnergyPage.ValidateHaveNoBillElectricityIDontKnow();
        }

        [Given(@"I have set Your Energy Page Electricity only section with table information")]
        public void GivenIHaveSetYourEnergyPageElectricityOnlySectionWithTableInformation(Table table)
        {
            var homeSize = table.Rows[0][0];
            var numberOfPeople = table.Rows[0][1];
            var sourceOfHeating = table.Rows[0][2];
            var temperature = table.Rows[0][3];
            var insulation = table.Rows[0][4];
            var cookingEnergySource = table.Rows[0][5];
            var timesAtHome = table.Rows[0][6];
            _detailsPage = _helperClass.BaseClass.YourEnergyPage
                .ElectricityEnergyUsage(homeSize, numberOfPeople, sourceOfHeating, temperature, 
                insulation, cookingEnergySource, timesAtHome).GoToYourDetailsPage();
        }


    }
}
