dotnet sonarscanner begin /k:"MyThinkBook" /d:sonar.host.url="http://localhost:9000"  /d:sonar.login="sqp_ec5b342502c613f60d79f4a63ab6ed8ccd4e7aa4" /d:sonar.cs.vscoveragexml.reportsPaths=mythinkbook-coverage.xml
dotnet build --nologo
dotnet test --no-build --nologo
dotnet-coverage collect 'dotnet test --no-build --nologo' -f xml  -o 'mythinkbook-coverage.xml'
dotnet sonarscanner end /d:sonar.login="sqp_ec5b342502c613f60d79f4a63ab6ed8ccd4e7aa4"