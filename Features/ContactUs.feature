Feature: Contact form
	Perform negative test to catch an error

@ContactPostive
Scenario: user fill the contact form - positive
	Given the Perfedct Ward "home-page" is displayed
	When the user click the "Contact" menu
	And the user fill the contact form
		| firstName | lastName | email      | telephone   | roles   | sectors | companyName | referralChannel | message | gdpr  |
		| Joey		| Blogings | JB@JB.com	| 0740000000  | CTO/CIO | Clinic  | JB Limited  | Referral        | msg-test| check |
	Then the form should be successful submitted

@ContactNegative
Scenario: user did not complete form - negative
	Given the Perfedct Ward "home-page" is displayed
	When the user click the "Contact" menu
	And the user fill the contact form
	| firstName | lastName | email      | telephone   | roles   | sectors | companyName | referralChannel | message | gdpr  |
	| Joey		| Blogings | JB@JB.com	| 0740000000  | CTO/CIO | Clinic  | JB Limited  | Referral        |         | check |
	But if the user miss a require field
	Then the form should display a validation error