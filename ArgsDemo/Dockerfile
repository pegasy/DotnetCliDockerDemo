FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

COPY ArgsDemo/ArgsDemo.csproj ./ArgsDemo/

RUN dotnet restore ArgsDemo/*.csproj

# copy everything else and build
COPY ArgsDemo/ ./ArgsDemo

RUN dotnet publish ArgsDemo/ArgsDemo.csproj -c Release -o /app/out

# build runtime image
FROM mcr.microsoft.com/dotnet/core/runtime:3.1
WORKDIR /app

COPY --from=build-env /app/out ./
ENTRYPOINT ["dotnet", "ArgsDemo.dll"]
