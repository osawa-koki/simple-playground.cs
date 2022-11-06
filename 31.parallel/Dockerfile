#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["31.parallel/31.parallel.csproj", "31.parallel/"]
RUN dotnet restore "31.parallel/31.parallel.csproj"
COPY . .
WORKDIR "/src/31.parallel"
RUN dotnet build "31.parallel.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "31.parallel.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "31.parallel.dll"]