#dotnet-coverage collect dotnet test --no-build
# dotnet-coverage collect dotnet test --no-build --output="mythinkbook.coverage"
dotnet-coverage collect dotnet test --settings "coverage-config.xml" --no-build --output="mythinkbook.coverage"
# dotnet-coverage collect dotnet test --settings "coverage-config.xml" --no-build --output-format="xml" --output="mythinkbook-coverage.xml"