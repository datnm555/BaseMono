FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR home/app

# Copy everything
COPY . .
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish ./src/Presentation/BaseMono.API/BaseMono.API.csproj -o /publish/
WORKDIR /publish

# Build runtime image
ENV ASPNETCORE_URLS=http://+:5000
ENTRYPOINT ["dotnet", "BaseMono.API.dll"]