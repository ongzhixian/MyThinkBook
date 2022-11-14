# dotnet CLI

dotnet tool install -g Microsoft.Web.LibraryManager.Cli
libman install @microsoft/signalr@latest -p unpkg -d wwwroot/js/signalr --files dist/browser/signalr.js --files dist/browser/signalr.js

dotnet new globaljson
dotnet new sln -n MyThinkBook
dotnet new mvc -n MyThinkBook.Web
dotnet sln .\MyThinkBook.sln add .\MyThinkBook.Web\

dotnet add .\MyThinkBook.Web\ package Microsoft.EntityFrameworkCore.Sqlite
dotnet add .\MyThinkBook.Web\ package NLog
dotnet add .\MyThinkBook.Web\ package NLog.Web.AspNetCore

Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package Microsoft.EntityFrameworkCore.SqlServer

dotnet user-secrets --project .\MyThinkBook.Web\ init


 dotnet new console -n MyThinkBook.Moca
 dotnet sln .\MyThinkBook.sln add .\MyThinkBook.Moca\

 Moca -- Monitoring, Observability Console Application
 

dotnet add .\MyThinkBook.Web\ package Dropbox.Api
dotnet add .\MyThinkBook.Web\ package RabbitMQ.Client

dotnet add .\MyThinkBook.Web\ package GraphQL.Client
dotnet add .\MyThinkBook.Web\ package GraphQL.Client.Serializer.SystemTextJson
-- if we need server implementation
dotnet add .\MyThinkBook.Web\ package GraphQL

dotnet add .\MyThinkBook.Web\ package Grpc.Tools
dotnet add .\MyThinkBook.Web\ package Grpc.AspNetCore


dotnet add .\MyThinkBook.Web\ package Microsoft.EntityFrameworkCore.Sqlite
dotnet add .\MyThinkBook.Web\ package Microsoft.EntityFrameworkCore.Design

dotnet add .\MyThinkBook.Web\ package Bogus
dotnet add .\MyThinkBook.Web\ package Microsoft.AspNetCore.Authentication.MicrosoftAccount


dotnet add .\MyThinkBook.Web\ package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet aspnet-codegenerator identity -dc WebApp1.Data.ApplicationDbContext --files "Account.Register;Account.Login;Account.Logout;Account.RegisterConfirmation"


dotnet add .\MyThinkBook.Web\ package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
dotnet add .\MyThinkBook.Web\ package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add .\MyThinkBook.Web\ package Microsoft.AspNetCore.Identity.UI

dotnet tool install -g dotnet-aspnet-codegenerator
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

dotnet aspnet-codegenerator identity -dc MyThinkBook.Web.Data.MyThinkBookDbContext --useDefaultUI
--OR--
dotnet aspnet-codegenerator identity -dc MyThinkBook.Web.Data.MyThinkBookDbContext --files "Account.Register;Account.Login"


dotnet aspnet-codegenerator identity -dc MyThinkBook.Web.Areas.Identity.Data.IdentityDataContext --useDefaultUI

dotnet aspnet-codegenerator identity -dc MyThinkBook.Web.Areas.Identity.Data.IdentityDataContext --files "Account.Register;Account.Login;Account.Logout;Account.RegisterConfirmation"


dotnet tool update --global dotnet-ef
dotnet ef migrations add CreateIdentitySchema --context MyThinkBook.Web.Areas.Identity.Data.IdentityDataContext --project .\MyThinkBook.Web\
dotnet ef database update --context MyThinkBook.Web.Areas.Identity.Data.IdentityDataContext --project .\MyThinkBook.Web\

dotnet ef migrations add 202212122215 --context MyThinkBook.Web.Data.MyThinkBookDbContext --project .\MyThinkBook.Web\
dotnet ef database update --context MyThinkBook.Web.Data.MyThinkBookDbContext --project .\MyThinkBook.Web\

http://localhost:5172

# Jetbrain Tools

https://www.jetbrains.com/help/rider/ReSharper_Command_Line_Tools.html

dotnet tool install -g JetBrains.ReSharper.GlobalTools

jb inspectcode YourSolution.sln -o=<PathToOutputFile>

jb inspectcode -o=D:\src\github\MyThinkBook\inspect-results.html -f=Html MyThinkBook.sln

https://www.jetbrains.com/help/dotcover/Running_Coverage_Analysis_from_the_Command_LIne.html#basic-scenario-for-net-core

dotnet tool install JetBrains.dotCover.GlobalTool -g


dotnet tool install --global JetBrains.dotTrace.GlobalTools

# SonarQube

dotnet tool install --global dotnet-sonarscanner
dotnet sonarscanner begin /k:"project-key" /d:sonar.login="<token>"
dotnet build <path to solution.sln>
dotnet sonarscanner end /d:sonar.login="<token>"

https://docs.sonarqube.org/latest/analyzing-source-code/scanners/sonarscanner/

Requires SonarQube server. 
We can download the community edition from:
https://www.sonarqube.org/downloads/

https://docs.sonarqube.org/latest/try-out-sonarqube/

C:\sonarqube\bin\windows-x86-64\StartSonar.bat

Once your instance is up and running, Log in to http://localhost:9000
System Administrator credentials:
login: admin
password: admin


    
dotnet sonarscanner begin /k:"MyThinkBook" /d:sonar.host.url="http://localhost:9000"  /d:sonar.login="sqp_ec5b342502c613f60d79f4a63ab6ed8ccd4e7aa4" /d:sonar.cs.vscoveragexml.reportsPaths=mythinkbook-coverage.xml
dotnet build
dotnet-coverage collect 'dotnet test' -f xml  -o 'mythinkbook-coverage.xml'
dotnet sonarscanner end /d:sonar.login="sqp_ec5b342502c613f60d79f4a63ab6ed8ccd4e7aa4"

# Coverage

dotnet tool install --global dotnet-coverage

`dotnet-coverage collect dotnet test`

dotnet-coverage collect dotnet test --no-build

https://learn.microsoft.com/en-us/dotnet/core/additional-tools/dotnet-coverage#settings
https://learn.microsoft.com/en-us/visualstudio/test/customizing-code-coverage-analysis?view=vs-2022

https://github.com/dotnet/docs/blob/main/docs/core/additional-tools/dotnet-coverage.md


dotnet test --collect:"XPlat Code Coverage" --filter FullyQualifiedName!~AspNetCoreGeneratedDocument

dotnet test --filter FullyQualifiedName!~AspNetCoreGeneratedDocument.* --collect:"XPlat Code Coverage"

dotnet test --collect:"XPlat Code Coverage" --filter FullyQualifiedName!~AspNetCoreGeneratedDocument --diag diag.log

dotnet test --collect:"Code Coverage" --filter FullyQualifiedName!~AspNetCoreGeneratedDocument

dotnet test --collect:"XPlat Code Coverage" /p:ExcludeFromCoverage=AspNetCoreGeneratedDocument*

dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:ExcludeByFile="**/program.cs"



dotnet test /p:CollectCoverage=true
See: https://discoverdot.net/projects/coverlet


dotnet test MyProject.csproj /p:CollectCoverage=true /p:ExcludeFromCoverage=AspNetCoreGeneratedDocument

dotnet test /p:CollectCoverage=true /p:ExcludeFromCoverage=AspNetCoreGeneratedDocument

dotnet test --filter FullyQualifiedName\!~AspNetCoreGeneratedDocument

AspNetCoreGeneratedDocument


https://learn.microsoft.com/en-us/visualstudio/test/microsoft-code-coverage-console-tool?view=vs-2022


# dotnet tools

 dotnet tool list -g
Package Id                            Version       Commands
-----------------------------------------------------------------------
dotnet-coverage                       17.5.0        dotnet-coverage
dotnet-ef                             6.0.0         dotnet-ef
dotnet-grpc                           2.41.0        dotnet-grpc
dotnet-sonarscanner                   5.2.1         dotnet-sonarscanner
jetbrains.dotcover.globaltool         2021.3.2      dotnet-dotcover
jetbrains.resharper.globaltools       2021.3.2      jb
microsoft.dotnet-httprepl             5.0.2         httprepl
microsoft.playwright.cli              1.2.2         playwright
microsoft.web.librarymanager.cli      2.1.161       libman
