#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["35.file_directory/35.file_directory.csproj", "35.file_directory/"]
RUN dotnet restore "35.file_directory/35.file_directory.csproj"
COPY . .
WORKDIR "/src/35.file_directory"
RUN dotnet build "35.file_directory.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "35.file_directory.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "35.file_directory.dll"]