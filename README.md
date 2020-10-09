# Hair Salon

#### Hair Salon allows a user to input stylists as well as clients for those stylists. Created On: 10/09/2020, Updated Last: 10/09/2020

#### By Janet Karpenske

## Description

Hair Salon is a C# program that uses a database to allow the user to add clients and stylists.

## Setup/Installation Requirements

## MySQL Workbench Schema Setup:
1. Open [MySql Workbench](https://www.mysql.com/products/workbench/) and connect to Local instance
2. Create a new sql tab by clicking the upper left icon: 'Create A New SQL Tab for Executing Queries'
3. Copy and paste the following code into "Query" and "Run":
---
### **Copy The Following Text**
CREATE DATABASE `janet_karpenske` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE janet_karpenske;
CREATE TABLE `clients` (
  `ClientId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `StylistId` int DEFAULT '0',
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Specialty` varchar(255) DEFAULT NULL,
  `DOB` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;



## Website Setup:
* Download or Clone project from Github repository.
* Open a terminal within BestRest folder within main project directory.
* Use command: 'dotnet restore' to install.
* After installation, type in 'dotnet build'.
* After build, run the program with 'dotnet run' in the terminal.
* If you don't have it already, create a "appsettings.json" file in the "BestRest" directory and Insert the code below with your user name and password for MySQL: 

> {
>  "ConnectionStrings": {
>      "DefaultConnection": "Server=localhost;Port=3306;database=janet_karpenske;uid={YOUR USERNAME};pwd={YOUR PASSWORD}"
>  }
>}



## Known Bugs

No Known Bugs

## Support and contact details

https://github.com/janetkarpenske

## Technologies Used

C#, LINQ, Entity Framework Core, MVCTest, MySql, CSHTML, CSS, Bootstrap and Markdown.

## Link To Active Site:
Not Applicable

### License

This software is licensed under the MIT license.

Copyright (c) 2016 **Janet Karpenske** - _Hair Salon_