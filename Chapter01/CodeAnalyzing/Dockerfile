FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Chapter01/CodeAnalyzing/CodeAnalyzing.csproj", "Chapter01/CodeAnalyzing/"]
RUN dotnet restore "Chapter01/CodeAnalyzing/CodeAnalyzing.csproj"
COPY . .
WORKDIR "/src/Chapter01/CodeAnalyzing"
RUN dotnet build "CodeAnalyzing.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CodeAnalyzing.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodeAnalyzing.dll"]
