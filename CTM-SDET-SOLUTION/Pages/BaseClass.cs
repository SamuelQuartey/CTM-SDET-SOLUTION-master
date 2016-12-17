using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CTM_SDET_SOLUTION.Pages
{
    public class BaseClass
    {
        protected IWebDriver Driver;
        private YourSupplierPage _energySupplier;
        private YourEnergyPage __energyEnergyPage;
        public BaseClass(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver,this);
        }

        public YourSupplierPage YourSupplierPage
        {
            get
            {
                _energySupplier = new YourSupplierPage(Driver);
                return _energySupplier;
            }
            
        }

        public YourEnergyPage YourEnergyPage
        {
            get
            {
                __energyEnergyPage = new YourEnergyPage(Driver);
                return __energyEnergyPage;
            }

        }
    }
}
