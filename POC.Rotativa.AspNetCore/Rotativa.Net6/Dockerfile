FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Rotativa.Net6/Rotativa.Net6.csproj", "Rotativa.Net6/"]
RUN dotnet restore "Rotativa.Net6/Rotativa.Net6.csproj"
COPY . .
WORKDIR "/src/Rotativa.Net6"
RUN dotnet build "Rotativa.Net6.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Rotativa.Net6.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Rotativa.Net6.dll"]