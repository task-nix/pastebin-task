#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:8085
EXPOSE 8085

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/IdentityServerHost.csproj", "src/"]
RUN dotnet restore "src/IdentityServerHost.csproj"
COPY . .
WORKDIR "/src/src"
RUN dotnet build "IdentityServerHost.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IdentityServerHost.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app

COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IdentityServerHost.dll"]