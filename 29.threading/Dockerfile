#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["29.threading/29.threading.csproj", "29.threading/"]
RUN dotnet restore "29.threading/29.threading.csproj"
COPY . .
WORKDIR "/src/29.threading"
RUN dotnet build "29.threading.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "29.threading.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "29.threading.dll"]