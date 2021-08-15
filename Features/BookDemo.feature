Feature: BookADemo
	Check that Book a Demo is visible across all top level menu "

@ignore
@SmokeBaD
Scenario: Check that book a demo is visible on all menu
	Given a user navigates to the "Home-page"
	And the home page loads properly
	Then the "Book-a-Demo" should be visible and enabled on the Home page
	When a user click the "IPC" menu
	And the IPC page loads properly
	Then the Book-a-Demo element should be visible and enabled on the IPC page
	When a user click the "Features" menu
	And the Features page loads properly
	Then the Book-a-Demo element should be visible and enabled on the Features page
	When a user click the "Our Solutions" menu
	And the Solutions page loads properly
	Then the Book-a-Demo element should be visible and enabled on the Solutions page
	When a user click the "Resources" menu
	And the Resources page loads properly
	Then the Book-a-Demo element should be visible and enabled on the Resources page
	When a user click the "News" menu
	And the News page loads properly
	Then the Book-a-Demo element should be visible and enabled on the News page
	When a user click the "Case Studies" menu
	And the Case Studies page loads properly
	Then the Book-a-Demo element should be visible and enabled on Case Studies page
	When a user click the "Webinar" menu
	And the Webinar page loads properly
	Then the Book-a-Demo element should be visible and enabled on Webinar page
	When  a user click the "Contact" menu
	And the Contact page loads properly
	Then the Book-a-Demo element should be visible and enabled on Contact page