Feature: ClickAbout
	In order to try specflow
	As a developer
	I want to click the About link

@mytag
Scenario: click about link
	Given I am on the Home page
	When I click the about tab
	Then I should see some text
