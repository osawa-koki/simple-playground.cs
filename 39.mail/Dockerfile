#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["39.mail/39.mail.csproj", "39.mail/"]
RUN dotnet restore "39.mail/39.mail.csproj"
COPY . .
WORKDIR "/src/39.mail"
RUN dotnet build "39.mail.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "39.mail.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "39.mail.dll"]