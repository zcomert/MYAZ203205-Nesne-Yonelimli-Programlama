dotnet new sln -o QueueApp
cd QueueApp
dotnet new classlib -o QueueLib
dotnet sln QueueApp add QueueLib
dotnet new webapi -o QueueApi
dotnet sln QueueApp add QueueApi
dotnet add QueueApi reference QueueLib
cd QueueApi
dotnet watch
