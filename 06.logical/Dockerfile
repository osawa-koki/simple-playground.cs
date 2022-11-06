#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["06.logical/06.logical.csproj", "06.logical/"]
RUN dotnet restore "06.logical/06.logical.csproj"
COPY . .
WORKDIR "/src/06.logical"
RUN dotnet build "06.logical.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "06.logical.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "06.logical.dll"]