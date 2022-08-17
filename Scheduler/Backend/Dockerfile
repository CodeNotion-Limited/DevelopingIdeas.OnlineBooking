FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base

WORKDIR /app
COPY . .
EXPOSE 5001
EXPOSE 5000

CMD ASPNETCORE_URLS=http://*:$PORT dotnet BlazorWasmAcademyServer.dll