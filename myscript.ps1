dotnet build ./Template.csproj
Write-Host ""

$from = "D:\MyProjects\AtomicropsMods\MyMods\RandomBosses\bin\Debug\netstandard2\RandomBosses.dll" 
$to = "D:\Games\Atomicrops\BepInEx\plugins"
Xcopy $from $to /v /f /y

# /v - verifies the to file is identical to the from file.
# /f - display from and to filenames
# /y - auto comfirm override 