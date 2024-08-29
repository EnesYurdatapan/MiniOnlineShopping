<b>It is a mini online shopping project. This project includes an enterprise-grade solution for building RESTful services using ASP.NET WebAPI and C#. Here is the list of that i did with this project and technologies that i've used: </b>
<br><br>
•CRUD operations for Categories and Products.<br>
•Authorization added. You need to be logged in and having a claim for add, update and delete operations.<br>
•Working with a real DB (MSSQL).<br>
•Entity Framework<br>
•IEntity, IDto, IEntityRepository, EfEntityRepositoryBase added.<br>
•Core Layer added.<br>
•WebAPI, JWT, IoC, Interceptors,Autofac.<br>
•Caching, Validation, Transaction, Performance Aspects<br>
<br><br>

<b>The rules that I tried to follow rules when writing this project</b>
<br><br>
•SOLID Principles<br>
•Clean Coding
<br><br>

<b>TO OPEN THE PROJECT ON YOUR LOCAL</b>
<br>
1.Clone the repository<br>
2.Open the project in Visual Studio<br>
3.Install database<br>
<br><br>
<b>DATABASE INSTALLATION</b>
<br>
1.Find your SQL Server name in the "SQL Server Object Explorer" then change server name in "DataAccess/Concrete/EntityFramework/NorthwindContext.cs<br>
2.Open cmd or any command shell in DataAccess file<br>
3.Run dotnet tool install --global dotnet-ef command to install .Net Entity Framework CLI<br>
4.Run dotnet ef database update to create the database<br>

