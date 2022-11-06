#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["26.extend_object/26.extend_object.csproj", "26.extend_object/"]
RUN dotnet restore "26.extend_object/26.extend_object.csproj"
COPY . .
WORKDIR "/src/26.extend_object"
RUN dotnet build "26.extend_object.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "26.extend_object.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "26.extend_object.dll"]