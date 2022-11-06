#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["25.interface/25.interface.csproj", "25.interface/"]
RUN dotnet restore "25.interface/25.interface.csproj"
COPY . .
WORKDIR "/src/25.interface"
RUN dotnet build "25.interface.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "25.interface.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "25.interface.dll"]