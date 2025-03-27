Feature: login

A short summary of the feature

@tag1
Scenario: Login with ModelTableData Credentials
	Given I have accessed the Swag Labs Login Page
	When I enter the Credential Details
	| username      | password     |
	| standard_user | secret_sauce |
	And I Click Login Button
	Then I should Navigate to the Product Page
	And I Add Two products to basket
	Then confirm the total number of products in the basket
	And Logout.
	


	@tag2
Scenario: Login with Table Credentials
	Given I have accessed the Swag Labs Login Page
	When I enter the Login Credential Details
	| username      | password     |
	| standard_user | secret_sauce |
	And I Click Login Button
	Then I should Navigate to the Product Page
	And I Add Two products to basket
	Then confirm the total number of products in the basket
	And Logout.

	@tag3
Scenario: Login
	Given I have accessed the Swag Labs Login Page
	When I enter a 'standard_user' UserName and 'secret_sauce' Password
	And I Click Login Button
	Then I should Navigate to the Product Page
	And I Add Two products to basket
	Then confirm the total number of products in the basket
	And Logout.