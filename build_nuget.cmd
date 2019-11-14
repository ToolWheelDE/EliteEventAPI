@ECHO off

dotnet build -c Release src\EliteEventAPI.Core\EliteEventAPI.Core.csproj
dotnet build -c Release src\EliteEventAPI.EDSM\EliteEventAPI.EDSM.csproj
dotnet build -c Release src\EliteEventAPI.Storage\EliteEventAPI.Storage.csproj

dotnet pack -c Release src\EliteEventAPI.Core\EliteEventAPI.Core.csproj
dotnet pack -c Release src\EliteEventAPI.EDSM\EliteEventAPI.EDSM.csproj
dotnet pack -c Release src\EliteEventAPI.Storage\EliteEventAPI.Storage.csproj

