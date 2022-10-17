FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["JustForTesting/JustForTesting.csproj", "JustForTesting/"]
RUN dotnet restore "JustForTesting/JustForTesting.csproj"
COPY . .
WORKDIR "/src/JustForTesting"
RUN dotnet build "JustForTesting.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JustForTesting.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JustForTesting.dll"]
