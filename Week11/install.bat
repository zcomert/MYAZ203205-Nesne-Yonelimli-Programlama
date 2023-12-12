mkdir Extension
cd Extension

dotnet new sln -n Extension
dotnet new classlib -o IntLib
dotnet new webapi -o IntApi

dotnet sln .\Extension.sln add IntLib
dotnet sln .\Extension.sln add IntApi

dotnet add .\IntApi reference IntLib
