FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Rotativa/Rotativa.csproj", "Rotativa/"]
RUN dotnet restore "Rotativa/Rotativa.csproj"
COPY . .
WORKDIR "/src/Rotativa"
RUN dotnet build "Rotativa.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Rotativa.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Rotativa.dll"]