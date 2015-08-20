Feature: JSONSerializer
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Return Empty JSON
	Given I have an empty Class
	When I press serialize
	Then the result should be {}
