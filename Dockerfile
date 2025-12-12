# STAGE 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution and project files
COPY ./Learning.OrderService.slnx ./

# Copy the rest of the source
COPY . .

# Restore dependencies
RUN dotnet restore Learning.OrderService.API/Learning.OrderService.API.csproj
RUN dotnet restore Learning.OrderService.Infrastructure/Learning.OrderService.Infrastructure.csproj
RUN dotnet restore Learning.OrderService.Domain/Learning.OrderService.Domain.csproj
RUN dotnet restore Learning.OrderService.Application/Learning.OrderService.Application.csproj

# Build and publish
WORKDIR /src/Learning.OrderService.API
RUN dotnet publish -c Release -o /app/publish

# STAGE 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Set ASP.NET Core to listen on port 8081
ENV ASPNETCORE_URLS=http://+:8081

# Set environment to Production
ENV ASPNETCORE_ENVIRONMENT=Production

# Copy published output
COPY --from=build /app/publish .

# Expose port 8081
EXPOSE 8081

# Run the API
ENTRYPOINT ["dotnet", "Learning.OrderService.API.dll"]