using Module5.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5.Pages.AddCustomerPages
{
    public class TelecomAddCustomerSuccessPage:BasePage
    {
        public TelecomAddCustomerSuccessPage(IWebDriver driver, ExtentReportsHelper extent)
        {
            this.driver = driver; 
            this.extent = extent; 
        }

        private By lblCustomerId = By.XPath("*//h3");

        public TelecomAddCustomerSuccessPage VerifyCustomerId()
        {
            Assert.IsTrue(FindElement(lblCustomerId).Displayed);
           extent.SetStepPass($"Customer Id: {FindElement(lblCustomerId).Text}");
            extent.TakeScreenshot("SuccessPage", driver);

            return this;
        }
    }
}
