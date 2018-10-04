FROM microsoft/dotnet:2.1-runtime-alpine

WORKDIR /app
COPY bin/Debug/netcoreapp2.1/publish/ .

ENTRYPOINT ["dotnet", "ConsoleApp.dll"]