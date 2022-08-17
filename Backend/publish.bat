::Remove old files
rmdir /S /Q .\bin

:: build be
cd ./\BlazorWasmAcademyServer
dotnet publish -c Release
cd ..

::login heroku
CALL heroku container:login

::build app
docker build -t registry.heroku.com/blazor-wasm-academy-server/web ./BlazorWasmAcademyServer/bin/Release/net6.0/publish

::push
docker push registry.heroku.com/blazor-wasm-academy-server/web

::release
heroku container:release web --app blazor-wasm-academy-server