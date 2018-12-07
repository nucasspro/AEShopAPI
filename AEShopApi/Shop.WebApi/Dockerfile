#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["Shop.WebApi/Shop.WebApi.csproj", "Shop.WebApi/"]
COPY ["Shop.Domain/Shop.Domain.csproj", "Shop.Domain/"]
COPY ["Shop.Common/Shop.Common.csproj", "Shop.Common/"]
COPY ["Shop.Service/Shop.Service.csproj", "Shop.Service/"]
RUN dotnet restore "Shop.WebApi/Shop.WebApi.csproj"
COPY . .
WORKDIR "/src/Shop.WebApi"
RUN dotnet build "Shop.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Shop.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Shop.WebApi.dll"]