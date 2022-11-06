#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["37.network/37.network.csproj", "37.network/"]
RUN dotnet restore "37.network/37.network.csproj"
COPY . .
WORKDIR "/src/37.network"
RUN dotnet build "37.network.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "37.network.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "37.network.dll"]