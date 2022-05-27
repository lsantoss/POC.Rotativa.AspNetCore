FROM mcr.microsoft.com/dotnet/aspnet:2.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:2.1 AS build
WORKDIR /src
COPY ["Rotativa.NetCore2.1/Rotativa.NetCore2.1.csproj", "Rotativa.NetCore2.1/"]
RUN dotnet restore "Rotativa.NetCore2.1/Rotativa.NetCore2.1.csproj"
COPY . .
WORKDIR "/src/Rotativa.NetCore2.1"
RUN dotnet build "Rotativa.NetCore2.1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Rotativa.NetCore2.1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Rotativa.NetCore2.1.dll"]