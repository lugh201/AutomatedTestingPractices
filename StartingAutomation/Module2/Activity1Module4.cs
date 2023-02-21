using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Module2
{
    public class Activity1Module4
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/newtours/"); // Step 1

            driver.FindElement(By.LinkText("REGISTER")).Click(); //step 2

            Console.WriteLine("Register Page is displayed");//step 3

            //step 4
            driver.FindElement(By.Name("firstName")).SendKeys("Louie");
            driver.FindElement(By.Name("lastName")).SendKeys("Gutierrez");
            driver.FindElement(By.Name("phone")).SendKeys("870000");
            driver.FindElement(By.Id("userName")).SendKeys("lg123@decembertraining.com");

            Console.WriteLine("Contact Information Fields are populated");//step 5

            //Step 6
            driver.FindElement(By.Name("address1")).SendKeys("Uptown Tower 3");
            driver.FindElement(By.Name("city")).SendKeys("Taguig");
            driver.FindElement(By.Name("state")).SendKeys("Metro Manila");
            driver.FindElement(By.Name("postalCode")).SendKeys("13209");
            SelectElement dropDown = new SelectElement(driver.FindElement(By.Name("country")));
            dropDown.SelectByValue("PHILIPPINES");

            Console.WriteLine("Mailing Information Fields are populated."); //step 7

            //Step 8
            driver.FindElement(By.Id("email")).SendKeys("auto1");
            driver.FindElement(By.Name("password")).SendKeys("password1");
            driver.FindElement(By.Name("confirmPassword")).SendKeys("password1");

            //Step 9 
            Console.WriteLine("USer Information Fields are populated.");


            driver.FindElement(By.Name("submit")).Click(); //step 10

            Console.WriteLine("Register Success Page is displayed");//step 11

            //step 12
            IWebElement registerNotif = driver.FindElement(By.XPath("//font[contains(text(), 'Thank you for registering')]"));
            if (registerNotif.Displayed)
            {
                Console.WriteLine("Thank you for registering text description is displayed");
            }


            driver.FindElement(By.XPath("//a[@href ='login.php']")).Click(); //step 13

            Console.WriteLine("Sign-On Page is displayed"); //step 14

            //Step 15
            driver.FindElement(By.Name("userName")).SendKeys("auto1");
            driver.FindElement(By.Name("password")).SendKeys("password1");

            driver.FindElement(By.Name("submit")).Click();

            Console.WriteLine("Login Success Page is displayed."); // step 17

            //Step 18
            IWebElement loginNotif = driver.FindElement(By.XPath("//h3[contains(text(), 'Login Successfully')]"));
            if (loginNotif.Displayed)
            {
                Console.WriteLine("Login Successfully text description is displayed");
            }


            driver.Quit();


            Console.ReadLine();

        }

    }
}
