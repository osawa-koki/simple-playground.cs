#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["18.advanced_string/18.advanced_string.csproj", "18.advanced_string/"]
RUN dotnet restore "18.advanced_string/18.advanced_string.csproj"
COPY . .
WORKDIR "/src/18.advanced_string"
RUN dotnet build "18.advanced_string.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "18.advanced_string.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "18.advanced_string.dll"]