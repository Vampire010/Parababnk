Feature: Login_kidsbank
	Login test case for kidsbank

@LoginTestCase_01
Scenario: Add two numbers
	Given User should be on Kidsbank Login page
	Then Enter Banker_ID
	Then Enter UserName
	Then Enter the Usr_Password
	And  Click Login_Button