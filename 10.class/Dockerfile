#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["10.class/10.class.csproj", "10.class/"]
RUN dotnet restore "10.class/10.class.csproj"
COPY . .
WORKDIR "/src/10.class"
RUN dotnet build "10.class.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "10.class.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "10.class.dll"]