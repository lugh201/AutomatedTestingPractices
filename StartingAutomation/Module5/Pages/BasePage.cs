using Module5.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5.Pages
{
    public class BasePage
    {
        public IWebDriver driver;
        public ExtentReportsHelper extent;
        public BasePage NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            extent.SetStepPass($"Navigated to url: {url}");
            return this;
        }
        
        public IWebElement FindElement(By element)
        {
            return driver.FindElement(element);
        }

        public BasePage Click(By element)
        {
            FindElement(element).Click();
            return this;
        }

        public BasePage EnterText(By element, string text)
        {
            FindElement(element).SendKeys(text);
            return this;
        }
    }
}
