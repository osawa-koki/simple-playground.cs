#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["33.regex/33.regex.csproj", "33.regex/"]
RUN dotnet restore "33.regex/33.regex.csproj"
COPY . .
WORKDIR "/src/33.regex"
RUN dotnet build "33.regex.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "33.regex.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "33.regex.dll"]