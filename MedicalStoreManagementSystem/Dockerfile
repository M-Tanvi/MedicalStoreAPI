FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MedicalStoreManagementSystem.csproj", "./"]
RUN dotnet restore "MedicalStoreManagementSystem.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "MedicalStoreManagementSystem.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MedicalStoreManagementSystem.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MedicalStoreManagementSystem.dll"]
