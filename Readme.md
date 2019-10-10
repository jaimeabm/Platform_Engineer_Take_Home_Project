# Platform Engineer Take Home Project

## Setting up the email account for notifications

Before running the app, please add the following values to the appsettings.json file.

```
"EmailSettings": {
    "Host": "smtp.gmail.com",
    "Port": 587,
    "EnableSsl": "true",
    "UserName": "<user gmail account.", //Set your gmail email here
    "Password": "<password>", //Set your gmail password here
    "On": "true"
  }
```

If you want to turno off the email notification, just set the property "On" to *false*.

### Allow Gmail to accepts client connections

Gmail smtp servers (secure ones) requires you to turn 'ON' the 'Less Secure Sign-In' option, if this step is not done, you will not be able to send email.


`https://myaccount.google.com/lesssecureapps?utm_source=google-account&utm_medium=web`


## Setting up the connection string

Before running the app, please update the connection string in the appsettings.json file.

```
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost,1401;DataBase=micasa;User=sa;Password=Password1234;"
  }
```

## How to download and run the SQL Server Docker image

The docker image is in the code but if you want to download a new image and do the setup by yourself, please follow the steps described below.

To download the docker *SQL Server linux image* execute the following command:

`sudo docker run -e --name 'sql1' -p 1401:1433 -v sql1data:/var/opt/mssql -d mcr.microsoft.com/mssql/server:2017-latest`

To check if the docker container is running:

`sudo docker ps`

To run and stop the docker container execute the following commands:

```
sudo docker start 'sql1'
sudo docker stop 'sql1'
```

## How to make migrations

If the **dotnet ef** tool is not found, execute the following command:

`dotnet tool install --global dotnet-ef`

To add a new migration just run the following command:

`dotnet ef migrations add [NAME_OF_THE_MIGRATION]`

To apply the migration in the database, just run the following command

`dotnet ef database update [NAME_OF_THE_MIGRATIONS]`

## Test from ngrok

This is only in case that you want to allow remote connections to your server in your laptop.

During the development of a web application, you may find yourself in a situation where you may need to access your local development web server from the public web. The most common scenario where this happens is when you need to test and debug webhooks since these need to be accessed from another system on the internet.

Before you can start using ngrok, you will need to connect your ngrok account. Log in to your ngrok account (or register for an account if you don’t have one yet) and go the Auth section of the dashboard. Here you will see your tunnel authentication token listed:

`./ngrok authtoken h0aihdfhadsifhajodsfhaiuhfahdsfh`

### Bad gateway error

This is only in case that you want to allow remote connections to your server in your laptop.

When I go to the URL the ngrok provides, I am greeted with an error 502 Bad Gateway. Searching the web, this seems to be a common problem when using ngrok with ASP.NET Core. Thankfully, among the many suggestions listed in that StackOverflow issue, there is a correct solution.

Stop ngrok and run it again with the following parameters:

`ngrok http https://localhost:5001 -host-header="localhost:5001"`

## How to copy the backup file from the docker image to the host?

```
sudo docker exec -it sql1 ls /var/opt/mssql/data/
sudo docker cp sql1:/var/opt/mssql/data/micasa-2019107-13-15-43.bak .
```

## How to publish the app from the command line

Packs the application and its dependencies into a folder for deployment to a hosting system.

`dotnet publish -c Release -o ./publish -r win-x64`

**-c|--configuration {Debug|Release}**

Defines the build configuration. The default value is Debug.

**-r|--runtime <RUNTIME_IDENTIFIER>**

Publishes the application for a given runtime. This is used when creating a self-contained deployment (SCD). 