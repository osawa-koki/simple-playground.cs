#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["02.variable/02.variable.csproj", "02.variable/"]
RUN dotnet restore "02.variable/02.variable.csproj"
COPY . .
WORKDIR "/src/02.variable"
RUN dotnet build "02.variable.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "02.variable.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "02.variable.dll"]