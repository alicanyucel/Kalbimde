FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Kalbimde.WebAPI/Kalbimde.WebAPI.csproj", "Kalbimde.WebAPI/"]
RUN dotnet restore "Kalbimde.WebAPI/Kalbimde.WebAPI.csproj"
COPY . .
WORKDIR "/src/Kalbimde.WebAPI"
RUN dotnet publish "Kalbimde.WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "Kalbimde.WebAPI.dll"]