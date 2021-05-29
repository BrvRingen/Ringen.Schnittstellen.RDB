dotnet build --configuration Release Ringen.Schnittstellen.RDB.sln
dotnet pack --configuration Release --no-build Ringen.Schnittstellen.RDB.sln  -o Artifacts/Packages

ECHO.
ECHO.Project Build and NuGet-Packages created.
pause > nul