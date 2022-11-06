#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["24.exception/24.exception.csproj", "24.exception/"]
RUN dotnet restore "24.exception/24.exception.csproj"
COPY . .
WORKDIR "/src/24.exception"
RUN dotnet build "24.exception.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "24.exception.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "24.exception.dll"]