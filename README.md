# WeatherAPI
This project is a RESTFUL API built in .NET 9, that provides endpoints for managing resources and performing CRUD operations.

## Features
- Authentication using a simple Login request, where a Username and Password is provided
- CRUD operations for Locations by Users
- In Memory database

## Technologies
- .NET 9

## Prerequisites
Before running this project, make sure you have installed
- .NET SDK

## Installation
1. Clone repository:
```
git clone repository https://github.com/fernandopalacios/WeatherApi.git
```
2. Install the dependencies
```
dotnet restore
```
3. Run the API
```
dotnet run
```
4. Authentication for this API is done by only providing an Username and a PIN. It does not require a Token and two users have been preloaded into the In Memory database for testing purposes:

| Username  | PIN   | 
|-----------|-------|
| lpalacios | 93024 |
| jperez    | 76253 |