## MousePark

This repository contains a Web API that tracks and manages theme parks and their attractions. Admins can create and manage existing attractions. Guests can view attractions and rate them on a 5-star scale. This was built as a group project submission for Eleven Fifty Academy's Software Development course and can be run locally on your computer..

#### Prerequisites
To run this program, you will need:
- Visual Studio Community
- A web browser
- Postman or another API testing program

#### Running the Program
- Clone to your local repository and open in VS Community.
- Open Package Manager Console. Select MousePark.Data as the default project and run "update-database" in the command line to seed the database.
- Run debugger. The API hyperlink at the top of the page will show you all available actions and test requirements.
- Open Postman to run tests. You'll need to Register and get a token to run certain tests.
  -	Admin can Post/Put/Delete objects in database.
  -	Guests/unregistered users can Get lists and details of existing objects, as well as create and manage Ratings for each object.
#### Bug Fix  
If upon running you receive an error “Cannot insert the value NULL into column ‘RatingId’”, you will need to make a small change to the Rating Table:  
- Open the SQL Server Object Explorer 
- Navigate to the MouseParkApi Database 
- Open Tables 
- Right-click on the Rating table and select "View Code" 
- Change the line “[RatingId] INT NOT NULL,” to “[RatingId] INT IDENTITY (1,1) NOT NULL,” 
- Select “Update” in the upper left corner of that window 
- Select “Update Database” on the pop-up 

#### Authors
- Alex Hamm  [/aphamm96](https://github.com/aphamm96)
- Summer Kerekes [/Phebesue](https://github.com/Phebesue)
- Fletcher Kitchell [/Fkitchell](https://github.com/Fkitchell)
- Sabra Snider [/slsnider727](https://github.com/slsnider727)

#### Resources Used

[Serializing Enums](https://exceptionnotfound.net/serializing-enumerations-in-asp-net-web-api/)

[Simple User Authorization and Allowing Anonymous Users to use GET methods](https://docs.microsoft.com/en-us/aspnet/core/security/authorization/simple?view=aspnetcore-3.1)

[More on Authentication and Authorization](https://docs.microsoft.com/en-us/aspnet/web-api/overview/security/authentication-and-authorization-in-aspnet-web-api)

[Account Management](https://bitoftech.net/2015/01/21/asp-net-identity-2-with-asp-net-web-api-2-accounts-management/) 

[More on Account Management](https://stackoverflow.com/questions/1407742/net-membership-in-ntier-app) 

[Data Annotations with FK](https://www.entityframeworktutorial.net/code-first/foreignkey-dataannotations-attribute-in-code-first.aspx)

[Routing Annotations](https://docs.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/routing-in-aspnet-web-api)

[LINQ Expressions](http://web.archive.org/web/20130918045955/http://msdn.microsoft.com/en-us/library/bb738550.aspx)

[More on LINQ Expressions](https://www.tutorialsteacher.com/linq/linq-expression)

[Understanding Lambda Expressions](https://www.tutorialsteacher.com/linq/linq-lambda-expression)
