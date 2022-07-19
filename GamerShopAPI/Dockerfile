FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR GamerShopAPI

EXPOSE 80
EXPOSE 5001

#COPY PROJECT FILES
COPY ./*.csproj ./
RUN dotnet restore

#COPY EVERYTHING ELSE
COPY . .
RUN dotnet publish -c Release -o out

#Build image
FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /GamerShopAPI
COPY --from=build /GamerShopAPI/out .
ENTRYPOINT ["dotnet", "GamerShopAPI.dll"]