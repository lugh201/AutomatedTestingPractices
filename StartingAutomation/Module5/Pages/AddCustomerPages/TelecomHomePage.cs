using Module5.Utilities;
using OpenQA.Selenium;


namespace Module5.Pages.AddCustomerPages
{
    public class TelecomHomePage:BasePage
    {
        public TelecomHomePage(IWebDriver driver, ExtentReportsHelper extent)
        {
            this.driver = driver;
            this.extent = extent;
        }

        private By linkAddCustomer = By.LinkText("Add Customer");

        public TelecomHomePage Verify()
        {
            Assert.IsTrue(FindElement(linkAddCustomer).Displayed);
            extent.SetStepPass("Add customer link is displayed");

            return this;
        }

        public TelecomAddCustomerPage ClickAddCustomerLink()
        {
            Click(linkAddCustomer);
            return new TelecomAddCustomerPage(driver, extent);

        }
    }
}
