#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["00.helloworld/00.helloworld.csproj", "00.helloworld/"]
RUN dotnet restore "00.helloworld/00.helloworld.csproj"
COPY . .
WORKDIR "/src/00.helloworld"
RUN dotnet build "00.helloworld.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "00.helloworld.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "00.helloworld.dll"]