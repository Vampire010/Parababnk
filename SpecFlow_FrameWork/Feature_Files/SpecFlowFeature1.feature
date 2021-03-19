Feature: ToDoApp
    Navigate to Parabank Website
    Login to the Parabank Website
    
 
@ToDoApp
Scenario: Login to the Parbank_Site
    Given that I am on the Parbank_Site
    Then Enter the Username 
    Then Enter the Password
    Then Click on Login_btn    
    And  verify whether user is logedin
    Then close the browser instance