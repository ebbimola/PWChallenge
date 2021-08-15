Feature: Check High All Level Menus are Accessible
		

Background: 
	Given That an exploratory test as been conducted

@SmokeHome
Scenario: Check Home page for accessible and book a demo is enable
	Given the Perfedct Ward home-page is displayed
	Then the "heading" should be visible
	And the "Book-a-Demo" element should be visible and enabled

@SmokeIPC
Scenario: check that IPC page is accessible and book a demo is enable
	Given the Perfect Ward home-page is displayed
	When the user click the "IPC" menu
	Then the "IPC" page should be displayed
	And the "Book-a-Demo" element should be visible and enabled

@SmokeFeatures
Scenario: check that Features page is accessible and book a demo is enable
	Given the Perfect Ward home-page is displayed
	When the user click the Features menu
	Then the Features page should be displayed
	And the "Book-a-Demo" element should be visible and enabled

@SmokeSolutions
Scenario: check that Our Solutions page is accessible and book-a-demo is enable
	Given the Perfect Ward home-page is displayed
	When the user click the Our Solution menu
	Then the Our Solution page should be displayed
	And the "Book-a-Demo" element should be visible and enabled

@SmokeResources
Scenario: check that Resources page is accessible and book-a-demo is enable
	Given the Perfect Ward home-page is displayed
	When the user click the Resources menu
	Then the Resources page should be displayed
	And the Book-a-Demo element should be visible and enabled

@SmokeNews
Scenario: check that News page is accessible and book-a-demo is enable
	Given the Perfect Ward home-page is displayed
	When the user click the News menu
	Then the News page should be displayed
	And the Book-a-Demo element should be visible and enabled

@SmokeCS
Scenario: check that Case Studies page is accessible and book-a-demo is enable
	Given the Perfect Ward home-page is displayed
	When the user click the Case Studies menu
	Then the Case Studies page should be displayed
	And the Book-a-Demo element should be visible and enabled

@SmokeWebinar
Scenario: check that Webinar page is accessible and book-a-demo is enable
	Given the Perfect Ward home-page is displayed
	When the user click the Webinar menu
	Then the Webinar page should be displayed
	And the Book-a-Demo element should be visible and enabled

@SmokeContact
Scenario: check that Contact page is accessible and book-a-demo is enable
	Given the Perfect Ward home-page is displayed
	When the user click the Contact menu
	Then the Contact page should be displayed
	And the Book-a-Demo element should be visible and enabled
