Feature: ContactFeature

@contact
Scenario: As user I want to check contact details
	Given I enter contact page
	When I check contact details
	Then Contact details are up to date
