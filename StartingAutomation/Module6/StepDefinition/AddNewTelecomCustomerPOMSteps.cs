using Module6.Drivers;
using Module6.Pages.AddCustomerPages;
using System;
using TechTalk.SpecFlow;

namespace Module6.StepDefinition
{
    [Binding]
    public class AddNewTelecomCustomerPOMSteps
    {
        private TelecomHomePage _homePage;
        private TelecomAddCustomerPage _addCustomerPage;
        private TelecomAddCustomerSuccessPage _addCustomerSuccessPage;

        public AddNewTelecomCustomerPOMSteps(DriverHelper helper)
        {
            _homePage = new TelecomHomePage(helper.driver);
        }

        [Given(@"User is on Telecom Homepage")]
        public void GivenUserIsOnTelecomHomepage()
        {
            _homePage.NavigateToHomePage();
        }

        [Given(@"User verifies that the Add Customer Link is displayed")]
        public void GivenUserVerifiesThatTheAddCustomerLinkIsDisplayed()
        {
            _homePage.Verify();
        }

        [When(@"User clicks on Add Customer Link")]
        public void WhenUserClicksOnAddCustomerLink()
        {
            _addCustomerPage = _homePage.ClickAddCustomerLink();
        }

        [Then(@"User is navigated to Add Customer Page")]
        public void ThenUserIsNavigatedToAddCustomerPage()
        {
            _addCustomerPage.Verify();

        }

        [Then(@"User verifies that the Add Customer Header is displayed")]
        public void ThenUserVerifiesThatTheAddCustomerHeaderIsDisplayed()
        {
            _addCustomerPage.Verify();

        }

        [When(@"User populates the required fields on Add Customer Page with ""([^""]*)"", ""([^""]*)"", ""([^""]*)"", ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserPopulatesTheRequiredFieldsOnAddCustomerPageWithTestautoTest_ComTestAddress(string firstname, string lastname, string email, string address,string telephone)
        {
            _addCustomerPage.FirstName = firstname;
            _addCustomerPage.LastName = lastname;
            _addCustomerPage.Email = email;
            _addCustomerPage.Address = address;
            _addCustomerPage.Telephone = telephone;
            _addCustomerPage.PopulateFields();
        }


        [When(@"User clocks on Submit Button on Add Customer Page")]
        public void WhenUserClocksOnSubmitButtonOnAddCustomerPage()
        {
            _addCustomerSuccessPage = _addCustomerPage.ClickSubmit();
        }

        [Then(@"User is navigated to Add Customer Success Page")]
        public void ThenUserIsNavigatedToAddCustomerSuccessPage()
        {
            _addCustomerSuccessPage.VerifyCustomerId();
        }

        [Then(@"User verifies that the Customer ID is Generated")]
        public void ThenUserVerifiesThatTheCustomerIDIsGenerated()
        {
            _addCustomerSuccessPage.VerifyCustomerId();

        }
    }
}
