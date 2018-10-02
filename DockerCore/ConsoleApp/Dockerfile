FROM FROM microsoft/dotnet:2.0-sdk

WORKDIR /app
COPY /bin/Debug/netcoreapp2.1/publish/ .

ENTRYPOINT ["dotnet", "ConsoleApp.dll"]