#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["34.environment/34.environment.csproj", "34.environment/"]
RUN dotnet restore "34.environment/34.environment.csproj"
COPY . .
WORKDIR "/src/34.environment"
RUN dotnet build "34.environment.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "34.environment.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "34.environment.dll"]