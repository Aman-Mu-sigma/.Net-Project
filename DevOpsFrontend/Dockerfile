# Stage 1: Build Stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

COPY DevOpsFrontend/DevOpsFrontend.csproj DevOpsFrontend/
RUN dotnet restore DevOpsFrontend/DevOpsFrontend.csproj

COPY DevOpsFrontend/. DevOpsFrontend/

WORKDIR /src/DevOpsFrontend

RUN dotnet publish -c Release -o /app/publish


# Stage 2: Runtime Stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

WORKDIR /app

ENV ASPNETCORE_URLS=http://+:8080

COPY --from=build /app/publish .

EXPOSE 8080

ENTRYPOINT ["dotnet", "DevOpsFrontend.dll"]