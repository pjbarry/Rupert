Feature: Networking
	In order to set up and configure Rupert
	As an administrator
	I want to see which machines are available to use Rupert


Scenario: View possible Murdochs
	Given I have opened the configuration screen
	When I click 'View Network'
	Then a list of machines on the network should appear 
	And an indicator wether each machine is a Murdoch should be shown

