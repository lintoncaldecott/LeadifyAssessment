# LeadifyAssessment
This is a simple contacts CRUD application for leadify, for their assessment. <br/>
I stole some styling elements from the leadify site. <br/>
I haven't been exceptionally careful with continuity per page, in terms of syling. <br/>
I have not limmited creation of contacts by any field, that all depends on some business rules. <br/>
I have created a unit test project, but not written any tests, I chipped away at this over my weekend with sick kids and a bajillion kids parties. Totally ran out of time.
<br/>
<br/>
The following requirements need to be met:

 Visual Studio 2015 needs to be used to create the application. - <B>DONE</B>

 SQL Server 2016 express or higher needs to be used to create the database together  - <B>DONE</B>

 All 3 rd party libraries and frameworks used in the app must be obtained as far as possible

using the NuGet package manager from within Visual Studio.  - <B>DONE</B>

 Bootstrap must be used to build the html frontend  - <B>DONE</B>

 Entity Framework must be used to connect to SQL Server from your application  - <B>DONE</B>

 Dependency injection must be used, you may use any dependency injection framework you

feel comfortable with.  - <B>DONE, Unity</B>

 The main web application must be an C# ASP.NET MVC 5 web application  - <B>DONE</B>

 Your application must target .NET framework 4.6.1  - <B>DONE</B>

 When you have completed your application it needs to be committed to a public Github

repository in order for us to review it. Please include all project files and a backup of the SQL

Server database.  - <B>DONE run Update-Database from package manager console to create the DB</B>

 Feel free to Google whatever you need to in order complete the project. If you do not know how to do something we would like to know how you found a solution to get it done. - <B> I had to check how to actually set up code first creation, and dependency injection. I used various tutorials to implement both of those. </B>

Instructions

1. Create a new database in SQL Server called leadifytest. - <B>DONE, using code first</B>

2. In the database create a new table called tbl contact with the following fields (use yourdiscretion as to what data types to use): - <B>DONE, with code first, datatypes all string, but input validation restricts what data can go in via the site</B>

3. Create a blank Visual Studio solution for the app and call it LeadifyTest - <B>DONE, except I called it LeadifyAssessment, renaming things broke ALL the things, so I kept it the same</B>

4. Within the solution create a new ASP.NET MVC5 web project - <B>DONE</B>

5. Create a listing page to list all the contacts in the database, with links to add, create and delete contacts- <B>DONE</B>

6. Create a page to add a new contact - <B>DONE</B>

7. Create a page to edit a contact - <B>DONE</B>

8. Ensure that all form fields use JQuery Validation and Unobtrusive validation. - <B>DONE</B>

9. Ensure that everything is MVC, i.e. use views and controllers and models to build your pages - <B>DONE</B>
