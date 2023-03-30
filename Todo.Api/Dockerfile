FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /App
COPY ./bin/Release/net7.0/publish /App
ENTRYPOINT ["dotnet", "Todo.Api.dll"]