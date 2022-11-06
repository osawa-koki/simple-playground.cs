#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["21.nullable_nunnullable/21.nullable_nunnullable.csproj", "21.nullable_nunnullable/"]
RUN dotnet restore "21.nullable_nunnullable/21.nullable_nunnullable.csproj"
COPY . .
WORKDIR "/src/21.nullable_nunnullable"
RUN dotnet build "21.nullable_nunnullable.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "21.nullable_nunnullable.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "21.nullable_nunnullable.dll"]