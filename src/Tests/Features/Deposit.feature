Feature: Deposit

A short summary of the feature


Scenario: Successful authorization with transition to the payment form
	Given Authorize with client "varytu@finews.biz" "Repepeg192@"
	When Navigate to Deposit
	When Navigate to Payop
	When Try to make a deposit
	Then Checkout page loaded

Scenario: Payop payment absent for the user
	Given Authorize with client "repepeg192@djpich.com" "Repepeg192@"
	When Navigate to Deposit
	Then Payop payment absent for the user