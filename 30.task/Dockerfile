#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["30.task/30.task.csproj", "30.task/"]
RUN dotnet restore "30.task/30.task.csproj"
COPY . .
WORKDIR "/src/30.task"
RUN dotnet build "30.task.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "30.task.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "30.task.dll"]