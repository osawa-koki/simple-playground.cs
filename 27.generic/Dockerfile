#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["27.generic/27.generic.csproj", "27.generic/"]
RUN dotnet restore "27.generic/27.generic.csproj"
COPY . .
WORKDIR "/src/27.generic"
RUN dotnet build "27.generic.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "27.generic.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "27.generic.dll"]