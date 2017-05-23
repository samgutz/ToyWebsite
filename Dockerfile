# FROM microsoft/aspnetcore:1.0.1
# ENTRYPOINT ["dotnet", "AspNetCoreHelloWorld.dll"]
# ARG source=.
# WORKDIR /app
# EXPOSE 80
# COPY $source .

# ENTRYPOINT ["dotnet", "AspNetCoreHelloWorld.dll"]



FROM microsoft/aspnetcore:1.0.4
COPY . /app
WORKDIR /app
 
# RUN ["dotnet", "restore"]
# RUN ["dotnet", "build"]
 
EXPOSE 5000/tcp
ENV ASPNETCORE_URLS http://*:5000
 
ENTRYPOINT ["dotnet", "AspNetCoreHelloWorld.dll"]