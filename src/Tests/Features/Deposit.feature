Feature: Deposit

A short summary of the feature

@tag1
Scenario: Successful authorization with transition to the payment form
	Given Authorize with client
	When Navigate to Deposit
	When Navigate to Payop
	When Try to make a deposit
	Then Checkout page loaded
