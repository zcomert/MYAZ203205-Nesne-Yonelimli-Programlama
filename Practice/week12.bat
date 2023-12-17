mkdir Week12
cd Week12

dotnet new sln -o RestaurantApp
cd RestaurantApp

dotnet new classlib -o Entities
dotnet new classlib -o Repositories
dotnet new webapi -o RestaurantApi

dotnet sln RestaurantApp.sln add Entities
dotnet sln RestaurantApp.sln add Repositories
dotnet sln RestaurantApp.sln add RestaurantApi

dotnet add Repositories reference Entities
dotnet add RestaurantApi reference Entities
dotnet add RestaurantApi reference Repositories

dotnet add Repositories package Microsoft.EntityFrameworkCore --version 7.0.0
dotnet add Repositories package Microsoft.EntityFrameworkCore.Tools --version 7.0.0
dotnet add Repositories package Microsoft.EntityFrameworkCore.Sqlite --version 7.0.0

dotnet add RestaurantApi package Microsoft.EntityFrameworkCore.Design --version 7.0.0

code .