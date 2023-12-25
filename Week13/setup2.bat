:: Projeleri oluştur
dotnet new sln -o ProductApp
cd ProductApp
dotnet new classlib -o Entities
dotnet new classlib -o Repositories
dotnet new classlib -o Services
dotnet new webapi -o ProductApi

:: Solution projeleri ekle
dotnet sln ProductApp.sln add Entities
dotnet sln ProductApp.sln add Repositories
dotnet sln ProductApp.sln add Services
dotnet sln ProductApp.sln add ProductApi

:: Referanslar 
dotnet add ProductApi reference Services
dotnet add ProductApi reference Repositories
dotnet add ProductApi reference Entities

dotnet add Services reference Repositories
dotnet add Services reference Entities

dotnet add Repositories reference Entities

:: Paketler
dotnet add Repositories package Microsoft.EntityFrameworkCore --version 7.0.0
dotnet add Repositories package Microsoft.EntityFrameworkCore.Tools --version 7.0.0
dotnet add Repositories package Microsoft.EntityFrameworkCore.Sqlite --version 7.0.0

dotnet add ProductApi package Microsoft.EntityFrameworkCore.Design --version 7.0.0

code .






