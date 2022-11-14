# Jetbrains CLI tools

## Tools 

1.  Resharper
2.  dotCover
3.  dotTrace

## Resharper CLI

The Resharper CLI tools composed of 2 tools:

1.  InspectCode, which executes hundreds of ReSharper code inspections
2.  CleanupCode, which instantly eliminates code style violations and ensures a uniform code base

### Installation

`dotnet tool install -g JetBrains.ReSharper.GlobalTools`

### Create InspectCode configuration XML

jb inspectcode --config-create="inspectcode-config.xml"

For configuring see: https://www.jetbrains.com/help/resharper/Code_Analysis__Configuring_Warnings.html

-exclude="**\Generated\**.*" -exclude="**\GetSocial\**.*"
--profile=yourSettings.DotSettings


### Running InspectCode

jb inspectcode --config="inspectcode-config.xml" --no-build MyThinkBook.sln 
jb inspectcode --config="inspectcode-config.xml" -o="inspect-results.xml"  MyThinkBook.sln
jb inspectcode --config="inspectcode-config.xml" -o="inspect-results.html" -f=Html --no-build --exclude="**/*.css" MyThinkBook.sln 

jb inspectcode -o=D:\src\github\MyThinkBook\inspect-results.xml  MyThinkBook.sln
jb inspectcode -o=D:\src\github\MyThinkBook\inspect-results.html -f=Html MyThinkBook.sln


Note:   The `-o` needs to be an absolute path in the above format. 
        Or it should be in quotes (like below).
--OR-- 
inspectcode .\MyThinkBook.sln -f="json" -o="CodeIssues.json"

For best results, use XML format.
The JSON format can crash sometimes for unknown reasons.


### Create CleanupCode configuration XML

jb cleanupcode --config-create="cleanupcode-config.xml"

### Running CleanupCode

jb cleanupcode MyThinkBook.sln

jb cleanupcode --config="cleanupcode-config.xml" MyThinkBook.sln

jb cleanupcode --config="cleanupcode-config.xml" --profile="Built-in: Reformat Code" MyThinkBook.sln

### CleanupCode built-in profiles

`Built-in: Reformat Code`                 that only applies code formatting preferences
`Built-in: Reformat & Apply Syntax Style` that applies code formatting preferences and code syntax styles.
`Built-in: Full Cleanup`                  that applies all available cleanup tasks except updating file header. (default)


Available code cleanup tasks
    Reformat code
    Syntax styles
    Optimize imports
    Rearrange code
    Remove redundancies & apply optimizations
    Update file header (copyright)
    Run external cleanup tools

See: https://www.jetbrains.com/help/resharper/Code_Cleanup__Index.html#reformat-code


## dotCover CLI

dotnet build
dotnet dotcover test
dotnet dotcover test --dcOutput=dotCover.Output.xml
dotnet dotcover report --source=dotCover.Output.dcvr --reportType=XML,JSON,HTML

dotnet dotcover <dotnet-command> [dotcover-parameters] [dotnet-parameters]
dotnet dotcover merge <dotcover-parameters>
dotnet dotcover report <dotcover-parameters>

dotnet dotcover test --no-build
dotnet dotcover test --dcReportType=XML


dotnet dotcover <dotnet-command> -h|--help
    dotnet-command = 'test' to run tests in the solution or 'exec' to run the application
dotnet dotcover merge -h|--help
dotnet dotcover report -h|--help

dotCover help cover dotcover-config.xml


Example:

`dotnet dotcover test`
Executes and covers unit tests found in a project or solution file in the current directory. Saves the results to dotCover.Output.dcvr

`dotnet dotcover merge --source=Snapshot1.dcvr;Snapshot2.dcvr`
Merges Snapshot1.dcvr and Snapshot2.dcvr located in the current directory into dotCover.Output.dcvr

`dotnet dotcover report --source=Snapshot.dcvr --reportType=XML,JSON`
Generates XML and JSON reports for Snapshot.dcvr located in the current directory. 
Saves the results to dotCover.Output.xml and dotCover.Output.json


## dotTrace CLI

https://www.jetbrains.com/help/profiler/Performance_Profiling__Profiling_Using_the_Command_Line.html#reporter


## dotMemory

No dotnet tool
Get executable from: https://www.jetbrains.com/dotmemory/download/#section=commandline

https://www.jetbrains.com/help/dotmemory/Working_with_dotMemory_Command-Line_Profiler.html
https://www.jetbrains.com/help/dotmemory/NET_Memory_Management_Concepts.html#memory-release