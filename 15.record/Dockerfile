#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["15.record/15.record.csproj", "15.record/"]
RUN dotnet restore "15.record/15.record.csproj"
COPY . .
WORKDIR "/src/15.record"
RUN dotnet build "15.record.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "15.record.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "15.record.dll"]