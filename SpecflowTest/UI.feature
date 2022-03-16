Feature: UI
Scenario: Test .net core application
Given I have started the chrome browser UI
And i am on the .netcore website
Then find the links count on home page
When i click on the about page 
Then display the about page title and print in console
When i click on the contact page
Then display the contact page title and content on the page and print in console