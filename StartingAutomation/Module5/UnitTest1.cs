using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Module5
{
    public class TelecomTests
    {
        public IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.guru99.com/telecom/index.html");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


        }

        [Test]
        public void AddTelecomCustomerTest1()
        {
           driver.FindElement(By.LinkText("Add Customer")).Click();
           
            if (driver.FindElement(By.XPath("//h1[text()='Add Customer']")).Displayed)
                Console.WriteLine("Add Customer Header is displayed.");

            driver.FindElement(By.XPath("//label[@for='done']")).Click();
            driver.FindElement(By.Id("fname")).SendKeys("Auto");
            driver.FindElement(By.Id("lname")).SendKeys("Tester");
            driver.FindElement(By.Id("email")).SendKeys("auto@test.com");
            driver.FindElement(By.Name("addr")).SendKeys("Test Address");
            driver.FindElement(By.Id("telephoneno")).SendKeys("0987654321");

            IWebElement btnSubmit = driver.FindElement(By.Name("submit"));
            btnSubmit.Click();

            Console.WriteLine("Add Customer Fields are populated.");

            IWebElement lblCustomerID = driver.FindElement(By.XPath("//h3"));
            if (lblCustomerID.Displayed)
                Console.WriteLine("Customer ID: " + lblCustomerID.Text + " is generated.");
        }

        [Test]
        public void AddTelecomCustomerTest2()
        {
            driver.FindElement(By.LinkText("Add Customer")).Click();

            if (driver.FindElement(By.XPath("//h1[text()='Add Customer']")).Displayed)
                Console.WriteLine("Add Customer Header is displayed.");

            driver.FindElement(By.XPath("//label[@for='done']")).Click();
            driver.FindElement(By.Id("fname")).SendKeys("Auto");
            driver.FindElement(By.Id("lname")).SendKeys("Tester");
            driver.FindElement(By.Id("email")).SendKeys("auto@test.com");
            driver.FindElement(By.Name("addr")).SendKeys("Test Address");
            driver.FindElement(By.Id("telephoneno")).SendKeys("0987654321");

            IWebElement btnSubmit = driver.FindElement(By.Name("submit"));
            btnSubmit.Click();

            Console.WriteLine("Add Customer Fields are populated.");

            IWebElement lblCustomerID = driver.FindElement(By.XPath("//h3"));
            if (lblCustomerID.Displayed)
                Console.WriteLine("Customer ID: " + lblCustomerID.Text + " is generated.");
        }

        [TearDown]
        public void EndTest()
        {
            driver.Quit();

        }
    }
}