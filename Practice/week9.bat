mkdir Week9
cd Week9
mkdir BlogPlatform
cd BlogPlatform

dotnet new sln -n BlogPlatform
dotnet new webapi -o BlogApi
dotnet new classlib -o BlogEntities
dotnet new classlib -o BlogRepositories

dotnet sln BlogPlatform.sln add BlogApi
dotnet sln BlogPlatform.sln add BlogEntities
dotnet sln BlogPlatform.sln add BlogRepositories

dotnet add BlogApi reference BlogRepositories
dotnet add BlogApi reference BlogEntities
dotnet add BlogRepositories reference BlogEntities

code .