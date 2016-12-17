﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CTM_SDET_SOLUTION.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class YourEnergyCompareFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "YourEnergyCompare.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "YourEnergyCompare", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "YourEnergyCompare")))
            {
                CTM_SDET_SOLUTION.Features.YourEnergyCompareFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ValidateGasAndElectricity")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "YourEnergyCompare")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Features")]
        public virtual void ValidateGasAndElectricity()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ValidateGasAndElectricity", new string[] {
                        "Features"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "PostCode",
                        "SupplierButtons"});
            table1.AddRow(new string[] {
                        "PE2 6YS",
                        "EDF Energy"});
#line 7
testRunner.Given("I have set Your Supplier Page Gas&ElectricityTab & YesCheckBox same supplier & Ye" +
                    "s, I have my bill Tab", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ElectricityTariff",
                        "Economy7Meter",
                        "Payment",
                        "HeatingSource",
                        "kWh",
                        "Duration"});
            table2.AddRow(new string[] {
                        "Standard (Variable)",
                        "No",
                        "Monthly Direct Debit",
                        "No",
                        "900",
                        "Annually"});
#line 11
testRunner.And("I have set Your Energy Page Electricity section with table information", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ElectricityTariff",
                        "Payment",
                        "HeatingSource",
                        "kWh",
                        "Duration"});
            table3.AddRow(new string[] {
                        "Standard (Variable)",
                        "Monthly Direct Debit",
                        "No",
                        "900",
                        "Annually"});
#line 15
testRunner.And("I have set Your Energy Page Gas section with table information", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Tariffs",
                        "PaymentType",
                        "EmailAddress"});
#line 19
 testRunner.When("I set Your Preferences page with table information, checked all checkbox & click " +
                    "GoToPrices button", ((string)(null)), table4, "When ");
#line 22
 testRunner.Then("I am on Your Results page with message \"<Your Results>\" displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion