using NUnit.Framework;
using OpenQA.Selenium;

namespace Module6.Pages.AddCustomerPages
{
    public class TelecomHomePage : BasePage
    {

        private string pageUrl = "https://demo.guru99.com/telecom/index.html";
        public TelecomHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By lnkAddCustomer = By.LinkText("Add Customer");

        public TelecomHomePage NavigateToHomePage()
        {
            NavigateToUrl(pageUrl);
            return this;
        }

        public TelecomHomePage Verify()
        {
            Assert.IsTrue(FindElement(lnkAddCustomer).Displayed);
            return this;
        }

        public TelecomAddCustomerPage ClickAddCustomerLink()
        {
            Click(lnkAddCustomer);
            return new TelecomAddCustomerPage(driver);
        }
    }
}