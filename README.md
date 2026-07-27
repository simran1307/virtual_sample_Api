# Restore all NuGet packages for the project
dotnet restore

# Build and run the application in the current directory
dotnet run --project ./YourProjectName \
           --configuration Debug \
           --verbosity minimal
# Build the Docker image from the Dockerfile in the current directory
docker build -t dotnet8webapi:latest \
             --build-arg DOTNET_VERSION=8.0 \
             --file ./Dockerfile .

# Run the container, mapping port 8080 on host to 8080 in container
docker run -d \
           --name dotnet8webapi_container \
           -p 8080:8080 \
           -e DOTNET_ENVIRONMENT=Development \
           dotnet8webapi:latest
