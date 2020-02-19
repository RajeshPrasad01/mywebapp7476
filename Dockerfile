# DockerFile for myWebApp7475
# Pulls from Microsoft Site dotnet/core

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-alpine AS build
WORKDIR /app

# Install dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy local code to container
COPY . ./
WORKDIR /app

# Build a release 
RUN dotnet publish -c Release -o out

# Use Microsoft's official runtime .Net image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-alpinecd AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# App port binding to 8080
ENV ASPNETCORE_URLS http://*:8080

# Run the webservice on container startup
ENTRYPOINT ["dotnet", "myWebApp7475.dll"]