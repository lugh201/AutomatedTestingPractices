using Module6.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6.Pages.AddCustomerPages
{
    public class TelecomAddCustomerSuccessPage:BasePage
    {
        public TelecomAddCustomerSuccessPage(IWebDriver driver)
        {
            this.driver = driver; 
        }

        private By lblCustomerId = By.XPath("*//h3");

        public TelecomAddCustomerSuccessPage VerifyCustomerId()
        {
            Assert.IsTrue(FindElement(lblCustomerId).Displayed);
         
            return this;
        }
    }
}
