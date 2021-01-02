FROM microsoft/dotnet:2.2-aspnetcore-runtime-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk-stretch AS build
WORKDIR /src
COPY ["Hahn.ApplicatonProcess.December2020.Web/Hahn.ApplicatonProcess.December2020.Web.csproj", "Hahn.ApplicatonProcess.December2020.Web/"]
RUN dotnet restore "Hahn.ApplicatonProcess.December2020.Web.csproj"
COPY . .
WORKDIR "/src/Hahn.ApplicatonProcess.December2020.Web"
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Hahn.ApplicatonProcess.December2020.Web.dll"]
