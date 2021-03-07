#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
EXPOSE 7000

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["src/ProntMed.UI.AppTest/ProntMed.UI.AppTest.csproj", "src/ProntMed.UI.AppTest/"]
RUN dotnet restore "src/ProntMed.UI.AppTest/ProntMed.UI.AppTest.csproj"
COPY . .
WORKDIR "/src/src/ProntMed.UI.AppTest"
RUN dotnet build "ProntMed.UI.AppTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProntMed.UI.AppTest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProntMed.UI.AppTest.dll"]