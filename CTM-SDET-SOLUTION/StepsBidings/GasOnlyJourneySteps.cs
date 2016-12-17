using CTM_SDET_SOLUTION.TestHooks;
using TechTalk.SpecFlow;

namespace CTM_SDET_SOLUTION.StepsBidings
{
    [Binding]
    public sealed class GasOnlyJourneySteps
    {
        private HelperClass _helperClass;
        public GasOnlyJourneySteps(HelperClass helper)
        {
            _helperClass = helper;
        }

        [Given(@"I have set Your Supplier Page table information, Gas Only Tab &  I have no bill Tab")]
        public void GivenIHaveSetYourSupplierPageTableInformationGasOnlyTabIHaveNoBillTab(Table table)
        {
            var postcode = table.Rows[0][0];
            var supplier = table.Rows[0][1];
            _helperClass.BaseClass.YourSupplierPage.ValidateGass(postcode, supplier);
        }

        [Given(@"I have set Your Energy Page Gas Only with table information")]
        public void GivenIHaveSetYourEnergyPageGasOnlyWithTableInformation(Table table)
        {
            var payment = table.Rows[0][0];
            var period = table.Rows[0][1];
            _helperClass.BaseClass.YourEnergyPage.ValidateHaveNoBillGas(payment, period);
        }


    }
}
