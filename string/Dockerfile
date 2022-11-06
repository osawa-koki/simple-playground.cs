#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["05.string/05.string.csproj", "05.string/"]
RUN dotnet restore "05.string/05.string.csproj"
COPY . .
WORKDIR "/src/05.string"
RUN dotnet build "05.string.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "05.string.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "05.string.dll"]
