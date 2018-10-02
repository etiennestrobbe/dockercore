FROM microsoft/dotnet:1.1-runtime-nanoserver

WORKDIR /app
COPY /bin/Debug/netcoreapp2.1/publish/ .

ENTRYPOINT ["dotnet", "ConsoleApp.dll"]