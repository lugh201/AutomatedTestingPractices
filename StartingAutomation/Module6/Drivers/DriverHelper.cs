using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Module6.Drivers
{
    public class DriverHelper
    {
        public IWebDriver driver;

        public DriverHelper()
        {
            driver = new ChromeDriver();
        }
    }
}
