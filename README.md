## Versions used: 
- Backend : .NET 6
- Frontend : Angular 16

## How to run project: 
Assumptions: You have .NET SDK, SQL Server, NPM, and Angular CLI installed. 
1. Open Visual Studio > Tool > Package Manager Console and run "update-database" command. 
2. If you face any problem in above step due SQL Server; you will need to update your Server Name in Connection String in AppSettings.Json File. 
3. Run the application from Visual Studio; upon success you will see swagger. 
4. Go to Angular Application and run the commands:
- npm i 
- ng serve
5. Open browser and go to http://localhost:4200/
