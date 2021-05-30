Feature: MenuCheckFeature

@menucheck
Scenario: As User I want to navigate to innovation page
	Given I enter ag-space main page
	When I click on innovation in menu
	Then I should be on innovation page

@menucheck
Scenario: As User I want to navigate to big data page
	Given I enter ag-space main page
	When I click on big data in menu
	Then I should be on big data page

@menucheck
Scenario: As User I want to navigate to earth observation page
	Given I enter ag-space main page
	When I click on earth observation in menu
	Then I should be on earth observation page

@menucheck
Scenario: As User I want to navigate to contour page
	Given I enter ag-space main page
	When I click on contour in menu
	Then I should be on contour page

@menucheck
Scenario: As User I want to navigate to grid page
	Given I enter ag-space main page
	When I click on grid in menu
	Then I should be on grid page

@menucheck
Scenario: As User I want to navigate to contact page
	Given I enter ag-space main page
	When I click on contact in menu
	Then I should be on contact page

@menucheck
Scenario: As User I want to navigate to what's new page
	Given I enter ag-space main page
	When I click on what's new in menu
	Then I should be on what's new page