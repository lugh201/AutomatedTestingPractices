using Microsoft.VisualBasic;
using Module5.Pages.AddCustomerPages;
using Module5.Utilities;
using OpenQA.Selenium;

namespace Module5.Tests
{
    [TestFixture]
    public class AddCustomerTest:BaseTest
    {
        [Test]
        public void AddTelecomCustomerTest()
        {
            var homepage = new TelecomHomePage(driver, extent);
            homepage.Verify();
            var addCustomerPage = homepage.ClickAddCustomerLink();
            addCustomerPage.Verify();
            addCustomerPage.FirstName = "Auto";
            addCustomerPage.LastName = "Test";
            addCustomerPage.Email = "auto@test.com";
            addCustomerPage.Address = "Test Address";
            addCustomerPage.Telephone = "0987654321";
            addCustomerPage.PopulateFields();
            var successPgage = addCustomerPage.ClickSubmit();
            successPgage.VerifyCustomerId();

        }
    }
}
