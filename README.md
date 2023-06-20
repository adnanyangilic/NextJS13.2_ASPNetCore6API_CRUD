# NextJS_13.2_and_ASP.Net_Core_6_API
ASP.Net core API signs its own ssl certificate but nextJS does not accept self signed ssl certificate.
To avoid SSL https conflicts between nextJS client and ASP.Net core API, I had to put http port before https port definition
in properties/launchSettings.json file in ASP.Net core API. I had to comment out app.UseHttpsRedirection(); instruction in 
Program.cs. I had to write 127.0.0.1 instead of localhost in NextJS API urls.

 First open ASP.Net Core API project in visual studio.
 Create a database in ms sqlserver management studio.
 Change connection string in appsettings.json file.
 Run update-database command in nuget package manager console.
 Run ASP.Net core project.
 To install node_modules and dependencies in nextJS project run:
# npm install
 to run nextJS project:
# npm run dev
