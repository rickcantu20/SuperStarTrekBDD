Feature: RaiseShield

Background: Shield setup
	Given Shield maximum is 10000 units
	And Shield is currently at 3000 units
	And Shield is currently down
	And Shield is not currently at 0 units

@mytag
Scenario: I raise the shield
	When I raise the shield
	Then the shield should be raised

Scenario: I transfer more than the shield can hold
	When I transfer 9000 to the Shield
	Then Shield should be at 10000

Scenario: I transfer energy the shield can hold
	When I transfer 1000 to the Shield
	Then Shield should be at 4000

Scenario: I transfer a negative value of energy to shield
	When I transfer -1000 to the Shield
	Then Shield should be at 2000
