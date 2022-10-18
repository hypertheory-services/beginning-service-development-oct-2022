#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BreakTimerApi/BreakTimerApi.csproj", "BreakTimerApi/"]
RUN dotnet restore "BreakTimerApi/BreakTimerApi.csproj"
COPY . .
WORKDIR "/src/BreakTimerApi"
RUN dotnet build "BreakTimerApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BreakTimerApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BreakTimerApi.dll"]