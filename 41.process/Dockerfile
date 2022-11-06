#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["41.process/41.process.csproj", "41.process/"]
RUN dotnet restore "41.process/41.process.csproj"
COPY . .
WORKDIR "/src/41.process"
RUN dotnet build "41.process.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "41.process.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "41.process.dll"]