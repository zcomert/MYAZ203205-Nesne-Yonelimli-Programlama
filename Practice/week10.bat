mkdir Week10
cd Week10
mkdir ShoppingPlatform
cd ShoppingPlatform

dotnet new sln -n ShopPlatform
dotnet new webapi -o ShopApi
dotnet new classlib -o ShopEntities
dotnet new classlib -o ShopRepositories

dotnet sln ShopPlatform.sln add ShopApi
dotnet sln ShopPlatform.sln add ShopEntities
dotnet sln ShopPlatform.sln add ShopRepositories

dotnet add ShopApi reference ShopRepositories
dotnet add ShopApi reference ShopEntities
dotnet add ShopRepositories reference ShopEntities

code .