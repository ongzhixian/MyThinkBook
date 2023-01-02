Clear
Write-Output "Processing file [$($args[0])]"
java -jar C:\Apps\bin\plantuml.jar $args[0]
Write-Output "Done."