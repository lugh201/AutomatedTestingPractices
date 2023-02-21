Feature: AddNewTelecomCustomer

Verify Add new telecom Customer flow is working as expected

#@Test
#Scenario: Add New Telecom Customer 
#	Given The User is on Telecom Home Page
#	When The User clicks on Add Customer Link
#	Then The User is redirected to Add Customer Page
#	When The User populates the Add Customer Fields
#	And The User clicks on Submit Button
#	Then The User is redirected to Add Customer Success Page
#	And The User verifies the Customer ID is Generated


@Test
Scenario Outline: Add New Telecom Customer - POM
	Given User is on Telecom Homepage
	And User verifies that the Add Customer Link is displayed
	When User clicks on Add Customer Link
	Then User is navigated to Add Customer Page
	And User verifies that the Add Customer Header is displayed
	When User populates the required fields on Add Customer Page with "<FirstName>", "<LastName>", "<Email>", "<Address>" and "<TelephoneNumber>"
	And User clocks on Submit Button on Add Customer Page
	Then User is navigated to Add Customer Success Page
	And User verifies that the Customer ID is Generated

	Examples:
	| FirstName | LastName | Email | Address | TelephoneNumber |
	| Auto | Test | auto@test.com | Test Address | 0987654321|
