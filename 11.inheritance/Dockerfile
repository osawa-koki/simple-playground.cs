#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["11.inheritance/11.inheritance.csproj", "11.inheritance/"]
RUN dotnet restore "11.inheritance/11.inheritance.csproj"
COPY . .
WORKDIR "/src/11.inheritance"
RUN dotnet build "11.inheritance.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "11.inheritance.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "11.inheritance.dll"]