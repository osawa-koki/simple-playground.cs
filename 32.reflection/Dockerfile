#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["32.reflection/32.reflection.csproj", "32.reflection/"]
RUN dotnet restore "32.reflection/32.reflection.csproj"
COPY . .
WORKDIR "/src/32.reflection"
RUN dotnet build "32.reflection.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "32.reflection.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "32.reflection.dll"]