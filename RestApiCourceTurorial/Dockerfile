FROM mcr.microsoft.com/dotnet/sdk:3.1 as build

ARG BUILDCONFIG=RELEASE
ARG VERSION=1.0.1

COPY RestApiCourceTurorial.csproj /build/

RUN dotnet restore ./build/RestApiCourceTurorial.csproj

COPY . ./build/
WORKDIR /build/
RUN dotnet publish ./RestApiCourceTurorial.csproj -c $BUILDCONFIG -o out /p:Version=$VERSION

FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app

COPY --from=build /build/out .

ENTRYPOINT ["dotnet", "RestApiCourceTurorial.dll"] 