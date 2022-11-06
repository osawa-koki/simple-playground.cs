#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["04.numeric/04.numeric.csproj", "04.numeric/"]
RUN dotnet restore "04.numeric/04.numeric.csproj"
COPY . .
WORKDIR "/src/04.numeric"
RUN dotnet build "04.numeric.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "04.numeric.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "04.numeric.dll"]