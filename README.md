# _Eau Claire's Salon_

#### _A program that allows a manager to manage stylists and their clients_

#### By _**Michael Kriegel**_

##### This project is a practice project

## Technologies Used

* _HTML/CSS_
* _Bootstrap_
* _MySQL_
* _C#_
* _Entity Framework_
* _ASP.NET 5.0_
* _Razor_

## Description

_This a program built for a salon owner. It allows the owner to create a list of stylists that are employed by the salon. Each list entry includes details pertaining the stylists name, style focus and schedule. Each stylist also has a number of clients that they serve. The manager is able to add clients to the stylist entries to keep things organized and know which client requires which stylist. If a stylist quits there is functionality to remove their entry on their departure. This program communicates with a database that has two tables and features a one to many relationship._

## Setup/Installation Requirements

### Local Machine
* _Clone this repository to your machine_
* _Navigate to the top level directory_
* _Navigate to the HairSalon directory (project directory)_
* _In the terminal, within this directory, enter the terminal commands "dotnet restore and dotnet build"_
* _Create an appsettings.json file_
* _Inside your appsettings.json, create a connection to the database you will be using_
  * _It will look similar to this: { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=(database_name_here);uid=(user_name_here));pwd=(your_password_here);" Leave out all parenthesis, they are for example purposes only_
* _Using MySQL workbench or another database management program that utilizes MySQL, import the .sql file to recreate the tables and columns necessary_

  _**For MySQL workbench:**_ 
  1. _log in to your workbench_
  2. _Select the administration tab in the navigator window_
  3. _Select "Data Import/Restore"_
  4. _In the import options select "Import from self-contained file"_
  5. _Select mikey_kriegel.sql_
  6. _Under "Default Schema to be imported to" select the "New" button_
  7. _Enter the name you would like for your database and select ok_
  8. _Select the Schemas tab and click the refresh icon in the top right corner or right click on the window and select Refresh All_
  9. _Your version of the project database should appear in the Schemas window_
* _To run the program, navigate to the HairSalon directory and enter the command "dotnet run" in the terminal_
  * _To run the program with a watcher, use the command "dotnet watch run" in the terminal_
* _Type the url localhost:5000 (or whatever port you have configured) in a browser to view the project_


## Known Bugs

* _Styling is not responsive for large or small screens_
* _Still figuring out how to style select box in client creation page_

## License

[MIT](https://opensource.org/licenses/MIT)

Copyright(c) 2021 Michael Kriegel

## Contact Information

Michael Kriegel: mikkrieg@gmail.com
