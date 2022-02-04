FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Rotativa.NetCore3.1/Rotativa.NetCore3.1.csproj", "Rotativa.NetCore3.1/"]
RUN dotnet restore "Rotativa.NetCore3.1/Rotativa.NetCore3.1.csproj"
COPY . .
WORKDIR "/src/Rotativa.NetCore3.1"
RUN dotnet build "Rotativa.NetCore3.1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Rotativa.NetCore3.1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Rotativa.NetCore3.1.dll"]