#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["09.function/09.function.csproj", "09.function/"]
RUN dotnet restore "09.function/09.function.csproj"
COPY . .
WORKDIR "/src/09.function"
RUN dotnet build "09.function.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "09.function.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "09.function.dll"]