:: Solution oluştur. 
dotnet new sln -o EmployeeApp
cd EmployeeApp

:: Projeleri Oluştur
dotnet new classlib -o Entities
dotnet new classlib -o Repositories
dotnet new classlib -o Services
dotnet new webapi -o EmployeeWebApi

:: Solution projeleri ekle
dotnet sln EmployeeApp.sln add Entities
dotnet sln EmployeeApp.sln add Repositories
dotnet sln EmployeeApp.sln add Services
dotnet sln EmployeeApp.sln add EmployeeWebApi

:: Referansları ekle
dotnet add EmployeeWebApi reference Entities
dotnet add EmployeeWebApi reference Repositories
dotnet add EmployeeWebApi reference Services

dotnet add Services reference Repositories
dotnet add Services reference Entities

dotnet add Repositories reference Entities

:: Paketler yükle
dotnet add Repositories package Microsoft.EntityFrameworkCore --version 7.0.0
dotnet add Repositories package Microsoft.EntityFrameworkCore.Tools --version 7.0.0
dotnet add Repositories package Microsoft.EntityFrameworkCore.Sqlite --version 7.0.0

dotnet add EmployeeWebApi package Microsoft.EntityFrameworkCore.Design --version 7.0.0