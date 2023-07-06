#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM --platform=$TARGETPLATFORM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["counter-dotnet/counter-dotnet.csproj", "counter-dotnet/"]
COPY ["counter-dotnet.library/counter-dotnet.library.csproj", "counter-dotnet.library/"]
RUN dotnet restore "counter-dotnet/counter-dotnet.csproj"
COPY . .
WORKDIR "/src/counter-dotnet"
RUN dotnet build "counter-dotnet.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "counter-dotnet.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "counter-dotnet.dll"]