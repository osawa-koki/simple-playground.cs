#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["36.stream/36.stream.csproj", "36.stream/"]
RUN dotnet restore "36.stream/36.stream.csproj"
COPY . .
WORKDIR "/src/36.stream"
RUN dotnet build "36.stream.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "36.stream.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "36.stream.dll"]