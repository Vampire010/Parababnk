﻿Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@mytag
Scenario: Add two numbers
	Given the first number is 40
	And the second number is 20
	When the two numbers are added
	Then the result should be 60