using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Module6.StepDefinition
{
    [Binding]
    public class AddNewTelecomCustomerSteps
    {
        public IWebDriver driver;

        [Given(@"The User is on Telecom Home Page")]
        public void GivenTheUserIsOnTelecomHomePage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.guru99.com/telecom/index.html");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [When(@"The User clicks on Add Customer Link")]
        public void WhenTheUserClicksOnAddCustomerLink()
        {
            IWebElement lnkAddCustomer = driver.FindElement(By.LinkText("Add Customer"));
            lnkAddCustomer.Click();
        }

        [Then(@"The User is redirected to Add Customer Page")]
        public void ThenTheUserIsRedirectedToAddCustomerPage()
        {
            IWebElement lblAddCustomerHeader = driver.FindElement(By.XPath("//h1[text()='Add Customer']"));
            if (lblAddCustomerHeader.Displayed)
                Console.WriteLine("Add Customer Header is displayed.");
        }

        [When(@"The User populates the Add Customer Fields")]
        public void WhenTheUserPopulatesTheAddCustomerFields()
        {
            driver.FindElement(By.XPath("//label[@for='done']")).Click();
            driver.FindElement(By.Id("fname")).SendKeys("Auto");
            driver.FindElement(By.Id("lname")).SendKeys("Tester");
            driver.FindElement(By.Id("email")).SendKeys("auto@test.com");
            driver.FindElement(By.Name("addr")).SendKeys("Test Address");
            driver.FindElement(By.Id("telephoneno")).SendKeys("0987654321");

        }

        [When(@"The User clicks on Submit Button")]
        public void WhenTheUserClicksOnSubmitButton()
        {
            IWebElement btnSubmit = driver.FindElement(By.Name("submit"));
            btnSubmit.Click();
            Console.WriteLine("Add Customer Fields are populated.");
        }

        [Then(@"The User is redirected to Add Customer Success Page")]
        public void ThenTheUserIsRedirectedToAddCustomerSuccessPage()
        {
            IWebElement lblCustomerID = driver.FindElement(By.XPath("//h3"));
            if (lblCustomerID.Displayed)
                Console.WriteLine("Customer ID: " + lblCustomerID.Text + " is generated.");
        }

        [Then(@"The User verifies the Customer ID is Generated")]
        public void ThenTheUserVerifiesTheCustomerIDIsGenerated()
        {
           
            driver.Quit();
        }
    }
}
