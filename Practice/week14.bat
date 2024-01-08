mkdir Week14
cd Week14

dotnet new sln -o LibraryApp
cd LibraryApp

dotnet new classlib -o Entities
dotnet new classlib -o Repositories
dotnet new webapi -o LibraryApi

dotnet sln LibraryApp.sln add Entities
dotnet sln LibraryApp.sln add Repositories
dotnet sln LibraryApp.sln add LibraryApi

dotnet add Repositories reference Entities
dotnet add LibraryApi reference Entities
dotnet add LibraryApi reference Repositories

dotnet add Repositories package Microsoft.EntityFrameworkCore --version 7.0.0
dotnet add Repositories package Microsoft.EntityFrameworkCore.Tools --version 7.0.0
dotnet add Repositories package Microsoft.EntityFrameworkCore.Sqlite --version 7.0.0

dotnet add LibraryApi package Microsoft.EntityFrameworkCore.Design --version 7.0.0

code .