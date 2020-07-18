#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["src/NovoTestApp/NovoTestApp.csproj", "src/NovoTestApp/"]
RUN dotnet restore "src/NovoTestApp/NovoTestApp.csproj"
COPY . .
WORKDIR "/src/src/NovoTestApp"
RUN dotnet build "NovoTestApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NovoTestApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NovoTestApp.dll"]