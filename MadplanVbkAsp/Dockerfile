FROM microsoft/aspnetcore:1.1.2

COPY . /app
WORKDIR /app

ENV ASPNETCORE_URLS http://*:7500
EXPOSE 7500

ENTRYPOINT dotnet MadplanVbkAsp.dll