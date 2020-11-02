Feature: Trigonometrical calculator
	As a user 
	I want to calculate trigonometricale numbers
	so that I'm able to calulate my homework


Scenario: sinus calculation
	When user calculates <number>
	Then the sinus should be calculated


Scenario: cosinus calculation
	Given an <number>
	When user calculates
	Then the cosinus should be calculated


Scenario: tangens calculation
	Given an <number>
	When user calculates
	Then the tanges should be calculated