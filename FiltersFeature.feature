Feature: FiltersFeature

@filters
Scenario: As user I want to search by keyword input
	Given I enter whats new page
	When I enter manufacutrer in text input
	Then I should only see news whth manufacturer in the content

@filters
Scenario: As user I want to filter by Africa market
	Given I enter whats new page
	When I check Africa check box
	Then I should only see news whth Africa in the content

@filters
Scenario: As user I want to filter by Contour market
	Given I enter whats new page
	When I check Contour check box
	Then I should only see news whth Contour in the content

@filters
Scenario: As user I want to filter by Global market
	Given I enter whats new page
	When I check Global check box
	Then I should only see news whth Global in the content

@filters
Scenario: As user I want to filter by UK market
	Given I enter whats new page
	When I check UK check box
	Then I should only see news whth UK in the content

@filters
Scenario: As user I want to filter by Contour product
	Given I enter whats new page
	When I check ContourProduct check box
	Then I should only see news whth ContourProduct in the content

@filters
Scenario: As user I want to filter by General product
	Given I enter whats new page
	When I check General check box
	Then I should only see news whth General in the content

@filters
Scenario: As user I want to filter by GRID product
	Given I enter whats new page
	When I check GRID check box
	Then I should only see news whth GRID in the content

@filters
Scenario: As user I want to filter by Blog type of comunication
	Given I enter whats new page
	When I check Blog check box
	Then I should only see news whth Blog in tags

@filters
Scenario: As user I want to filter by Case study type of comunication
	Given I enter whats new page
	When I check Case study check box
	Then I should only see news whth Case study in tags

@filters
Scenario: As user I want to filter by PR type of comunication
	Given I enter whats new page
	When I check PR check box
	Then I should only see news whth PR in tags

@filters
Scenario: As user I want to filter by Release note type of comunication
	Given I enter whats new page
	When I check Release note check box
	Then I should only see news whth Release note in tags

@filters
Scenario: As user I want to filter by Uncategorised type of comunication
	Given I enter whats new page
	When I check Uncategorised check box
	Then I should only see news whth Uncategorised in tags

@filters
Scenario: As user I want to filter by date range
	Given I enter whats new page
	When I enter from and end date
	Then I should only see news between those dates