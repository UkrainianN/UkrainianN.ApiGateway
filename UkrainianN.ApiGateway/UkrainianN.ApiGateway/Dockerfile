#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["UkrainianN.ApiGateway/UkrainianN.ApiGateway.csproj", "UkrainianN.ApiGateway/"]
RUN dotnet restore "UkrainianN.ApiGateway/UkrainianN.ApiGateway.csproj"
COPY . .
WORKDIR "/src/UkrainianN.ApiGateway"
RUN dotnet build "UkrainianN.ApiGateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UkrainianN.ApiGateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UkrainianN.ApiGateway.dll"]