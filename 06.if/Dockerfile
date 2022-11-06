#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["06.if/06.if.csproj", "06.if/"]
RUN dotnet restore "06.if/06.if.csproj"
COPY . .
WORKDIR "/src/06.if"
RUN dotnet build "06.if.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "06.if.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "06.if.dll"]