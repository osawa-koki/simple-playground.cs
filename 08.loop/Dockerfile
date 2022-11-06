#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["08.loop/08.loop.csproj", "08.loop/"]
RUN dotnet restore "08.loop/08.loop.csproj"
COPY . .
WORKDIR "/src/08.loop"
RUN dotnet build "08.loop.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "08.loop.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "08.loop.dll"]