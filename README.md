## Interview Submission

The web page should be mostly working. There are some links if you click on them (eg the Artist name at the top of the page), it doesn't go anywhere.

However, the Overview/Songs/Albums should all work and send to their own respective pages.
The View All Buttons also work.

I wasn't sure how you wanted to display the data for the svgs, so I just made them highlighted blue if they were available from the DB.
Limited Top songs to 3 and Albums to 6 on the main page, but the other two pages uses all of them.

In order to change artists, the parameter exists in the aspx.cs pages at the top of the PageLoad function, just add any artist id and the SP should work correctly.

For the API, I used a standard ASP Web API project with Swagger Support. If you run the API, it should load Swagger with the 3 endpoints from 2 controllers, which should allow you to test.

###If Extra Time
- Experiment with Entities and Mapping for SQL Calls. There is a better way to parse DataRows automatically.
- Add endpoints to everything that was classified as a hyperlink in the template.
- Add extra pages to showcase Details Page and API calls (This was not specified as necessary in the prompt, but would be nice if I added a searchbar to the end of the default page.)
- Map all pages to same artistID (This also was not specified as necessary, but either with a searchbar that used the artistID as a parameter, or a command line argument.)
- There is a way to do the pagination requested in sql, but the syntax was not working correctly for me.


Thanks for reviewing!
--------------------------------------------------------------------------------------------------------------------------
## Welcome!

So you want to work for MultiTracks.com? This is a step in the right direction!


This repo contains a Class Library and a Web Forms Website project. As a member of the DotNET server team at MultiTracks.com you will most likely find yourself in similar projects on a regular basis. We have a number of projects also utilizing DotNetCore and all new projects in DotNet 7.


To get started:

- Clone the repo locally	
- Open the solution in Visual Studio	
- Run "Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r" from the Package Manager Console	
- Finally run the project for further instructions
