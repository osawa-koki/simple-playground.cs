#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["28.lambda/28.lambda.csproj", "28.lambda/"]
RUN dotnet restore "28.lambda/28.lambda.csproj"
COPY . .
WORKDIR "/src/28.lambda"
RUN dotnet build "28.lambda.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "28.lambda.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "28.lambda.dll"]