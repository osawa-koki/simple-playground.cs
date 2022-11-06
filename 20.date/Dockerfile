#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["20.date/20.date.csproj", "20.date/"]
RUN dotnet restore "20.date/20.date.csproj"
COPY . .
WORKDIR "/src/20.date"
RUN dotnet build "20.date.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "20.date.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "20.date.dll"]