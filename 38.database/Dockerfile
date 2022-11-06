#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["38.database/38.database.csproj", "38.database/"]
RUN dotnet restore "38.database/38.database.csproj"
COPY . .
WORKDIR "/src/38.database"
RUN dotnet build "38.database.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "38.database.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "38.database.dll"]