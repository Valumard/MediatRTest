FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 59906
EXPOSE 44310

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["MediatrTest/MediatrTest.csproj", "MediatrTest/"]
RUN dotnet restore "MediatrTest/MediatrTest.csproj"
COPY . .
WORKDIR "/src/MediatrTest"
RUN dotnet build "MediatrTest.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MediatrTest.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MediatrTest.dll"]