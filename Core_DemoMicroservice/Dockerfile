#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.
# the ASP.NET Core 6 Base Object Model
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
# Working Director on Image wher App files will be copied and Build
WORKDIR /app
# http and https ports exposed by the Container
EXPOSE 80
EXPOSE 443
# Base Runtime i.e. .NET 6 SDK
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
# Working Directory where the dependencies will be managed in image
WORKDIR /src
# The Project file that conatians, Target Framework, other dependencies 
COPY ["Core_DemoMicroservice/Core_DemoMicroservice.csproj", "Core_DemoMicroservice/"]
# The dotnet restore command will add / restore all dependencies for the project inside the image 
RUN dotnet restore "Core_DemoMicroservice/Core_DemoMicroservice.csproj"
COPY . .
WORKDIR "/src/Core_DemoMicroservice"
# Build the Project with depenedencies
RUN dotnet build "Core_DemoMicroservice.csproj" -c Release -o /app/build
# Publish the Release Mode
FROM build AS publish
RUN dotnet publish "Core_DemoMicroservice.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
# Target to the app folder
WORKDIR /app
# Copy the published contents i.e. Dll so that it can be loaded in dotnet.exe in image 
COPY --from=publish /app/publish .
# Run dotnet.exe in image and load the application dll with all of its depednencies
ENTRYPOINT ["dotnet", "Core_DemoMicroservice.dll"]