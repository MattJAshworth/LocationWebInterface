# web-based-location-tracker
A uni project to fufill part two of the spec in [Spec.pdf](spec.pdf)

This is an asp.net website which allows people to store a user and their location, along with optional first name and last name in a database.

People can then have their locations displayed and edited, locations for the last 24 hours listed, show all the people in a given room, etc.

## Screenshots

![Home page](Screenshots/homepage.png?raw=true "Home page")
![Staff members in selected location](Screenshots/inlocation.png?raw=true "Staff members in selected location")
![Locations of all staff](Screenshots/locations.png?raw=true "Locations of all staff")
![Staff member's locations in the past 24 hours](Screenshots/past24.png?raw=true "Staff member's locations in the past 24 hours")
![Update a staff member's personal details](Screenshots/personaldetails.png?raw=true "Update a staff member's personal details")
![Update a staff member's location](Screenshots/updatelocation.png?raw=true "Update a staff member's location")

## Installation

You'll need visual studio, with asp.net extensions installed. Open visual studio, go to file -> new -> web site, then pick empty website.

Browse to the location you downloaded the files to, highlight them all, and drag them onto the Project name, under solution explorer. Replace any files which already exist.

You'll also need to make a sql database, with one table, USERS, with the columns - 

USERNAME - varchar(128) - Primary Key

FIRSTNAME - varchar(128) - allow nulls

LASTNAME - varchar(128) - allow nulls

LOCATION - varchar(128)

I used sql server 2008 as that's what the target machines were running, but it might work with other databases.

You'll then need to edit the database connection string in web.config. You can get the connection string by going on tools -> database connections then adding a new one.

## Running

Click the drop down arrow next to the green build/run arrow, and choose a browser such as chrome or firefox. The css doesn't work in internet explorer fully.

Hit the green build/run arrow, with the default.aspx page open.

It should open in your browser of choice and be fully working.

If you need to add people to the database, you can send get/post requests to location.aspx as detailed in the spec, or use the location.html page. You'll have to manually enter the url for this page.
