dotnet build -c Release src\EliteEventAPI.Core\EliteEventAPI.Core.nuget.csproj
dotnet build -c Release src\EliteEventAPI.EDSN\EliteEventAPI.EDSN.nuget.csproj
dotnet build -c Release src\EliteEventAPI.Storage\EliteEventAPI.Storage.nuget.csproj

dotnet pack -c Release src\EliteEventAPI.Core\EliteEventAPI.Core.nuget.csproj
dotnet pack -c Release src\EliteEventAPI.EDSN\EliteEventAPI.EDSN.nuget.csproj
dotnet pack -c Release src\EliteEventAPI.Storage\EliteEventAPI.Storage.nuget.csproj

