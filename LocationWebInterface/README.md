# web-based-location-tracker
This is an asp.net website which allows people to store a user and their location, along with optional first name and last name in a database.

People can then have their locations displayed and edited, locations for the last 24 hours listed, show all the people in a given room, etc.

## Installation
You'll also need to make a sql database, with one table, USERS, with the columns - 

USERNAME - varchar(128) - Primary Key

FIRSTNAME - varchar(128) - allow nulls

LASTNAME - varchar(128) - allow nulls

LOCATION - varchar(128)

I used sql server 2008 as that's what the target machines were running, but it might work with other databases.

You'll then need to edit the database connection string in web.config. You can get the connection string by going on tools -> database connections then adding a new one.

## Running
