# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS Build
WORKDIR /source
COPY . .
RUN dotnet restore "secondProject.csproj" --disable-parallel
RUN dotnet publish "secondProject.csproj" -c release -o /app --no-restore

# Serve Stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal 
WORKDIR /app
COPY --from=build /app ./

EXPOSE 9000

ENTRYPOINT [ "dotnet","secondProject.dll" ]
