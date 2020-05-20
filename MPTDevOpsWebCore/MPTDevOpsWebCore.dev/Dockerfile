FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
#COPY ["MPTDevOpsWebCore/MPTDevOpsWebCore.csproj", "MPTDevOpsWebCore/"]

COPY ["MPTDevOpsWebCore.csproj", "MPTDevOpsWebCore/"]
RUN dotnet restore "MPTDevOpsWebCore/MPTDevOpsWebCore.csproj"

RUN echo "----> webcore"
#COPY . .

COPY [".", "MPTDevOpsWebCore/"]
WORKDIR "/src/MPTDevOpsWebCore"
RUN dotnet build "MPTDevOpsWebCore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MPTDevOpsWebCore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MPTDevOpsWebCore.dll"]

#RUN docker build .
#RUN echo "FJXZNOLz7bdgXz=kahs2ppCV4yoDSefy" | docker login dlgtacr.azurecr.io --username DLGTACR --password-stdin
#RUN docker tag mptdevopswebcore:dev dlgtacr.azurecr.io/mptdevopswebcore:dev
#RUN docker push dlgtacr.azurecr.io/mptdevopswebcore:dev



