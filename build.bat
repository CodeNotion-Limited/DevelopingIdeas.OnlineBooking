cd ./Backend
start cmd.exe /k "(set ASPNETCORE_ENVIRONMENT=Development) & dotnet run"

cd ../Frontend
(set ASPNETCORE_ENVIRONMENT=Development) & nswag run /runtime:Net60

