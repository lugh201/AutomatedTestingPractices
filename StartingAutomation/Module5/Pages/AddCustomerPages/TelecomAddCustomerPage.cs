using Module5.Utilities;
using OpenQA.Selenium;
using System;


namespace Module5.Pages.AddCustomerPages
{
    public class TelecomAddCustomerPage : BasePage
    {
        public TelecomAddCustomerPage(IWebDriver driver, ExtentReportsHelper extent)
        {
            this.driver = driver;
            this.extent = extent;
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
           extent.SetStepPass("Add Customer Header is displayed.");

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
           extent.SetStepPass("Add Customer Fields are populated.");

            return this;
        }

        public TelecomAddCustomerSuccessPage ClickSubmit()
        {
            Click(btnSubmit);
            extent.SetStepPass("Submit button is clicked");
            return new TelecomAddCustomerSuccessPage(driver, extent);
        }
    }

}