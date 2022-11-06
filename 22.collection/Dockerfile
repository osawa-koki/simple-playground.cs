#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["22.collection/22.collection.csproj", "22.collection/"]
RUN dotnet restore "22.collection/22.collection.csproj"
COPY . .
WORKDIR "/src/22.collection"
RUN dotnet build "22.collection.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "22.collection.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "22.collection.dll"]