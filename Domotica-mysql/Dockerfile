FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Domotica-mysql/Domotica-mysql.csproj", "Domotica-mysql/"]
RUN dotnet restore "Domotica-mysql/Domotica-mysql.csproj"
COPY . .
WORKDIR "/src/Domotica-mysql"
RUN dotnet build "Domotica-mysql.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Domotica-mysql.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Domotica-mysql.dll"]