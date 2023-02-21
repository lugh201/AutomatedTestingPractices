using Module6.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;


namespace Module6.Pages.AddCustomerPages
{
    public class TelecomAddCustomerPage : BasePage
    {
        public TelecomAddCustomerPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Page Objects
        private By lblAddCustomerHeader = By.XPath("//h1[text()='Add Customer']");
        private By rBtnDone = By.XPath("*//label[@for='done']");
        private By tBoxFirstName = By.Id("fname");
        private By tBoxLastName = By.Id("lname");
        private By tBoxEmail = By.Id("email");
        private By tBoxAddress = By.Name("addr");
        private By tBoxTelepone = By.Id("telephoneno");
        private By btnSubmit = By.Name("submit");
        #endregion

        #region Getters and Setters

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        #endregion



        public TelecomAddCustomerPage Verify()
        {
            Assert.IsTrue(FindElement(lblAddCustomerHeader).Displayed);
           

            return this;
        }

        public TelecomAddCustomerPage PopulateFields()
        {
            Click(rBtnDone);
            EnterText(tBoxFirstName, FirstName);
            EnterText(tBoxLastName, LastName);
            EnterText(tBoxEmail, Email);
            EnterText(tBoxAddress, Address);
            EnterText(tBoxTelepone, Telephone);

            return this;
        }

        public TelecomAddCustomerSuccessPage ClickSubmit()
        {
            Click(btnSubmit);
           
            return new TelecomAddCustomerSuccessPage(driver);
        }
    }

}