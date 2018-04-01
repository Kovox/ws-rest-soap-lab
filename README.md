# ws-rest-soap-lab

SOAP Intermediary Web Service and Client for Velib (JCDecaux) application.

## Extensions

+ Cache added to IWS. Admin Gui available in project VelibServerGui
+ Gui application
+ Async service (From Client application to IWS and IWS to Velib service)
+ Deployment on Docker with Mono

## Projects usage

+ VelibClientConsole is the console application
+ VelibClientGui is the application provided with user interface. (Extension)
+ VelibLibrary is the IWS.
+ VelibLibraryDeployment is used for the deployment of the IWS.
+ VelibServerGui is the admin application provided with user interface. It allows the admin to manage the settings of the IWS Cache.

To use the different projects, do the following instructions:

1. Clone the git
2. Open an instance of Visual Studio **(as administrator)**
3. Open the VelibApplication.sln

## Deployment

I wanted to make the deployment independent from Visual Studio, this is why there is no .sln or .csproj. There is a file named Server.cs which allow to launch the server and get a .exe when compiling instead of having a .dll file. To compile the .cs files and run the .exe file with mono the steps are :

1. Launch compile.sh in the VelibLibraryDeployment directory
2. Open a cmd **(as administrator)** and run the following command in the VelibLibraryDeployment directory
```shell
mono server.exe
```

But what we want here is to deploy the server running under mono in a docker container.
To do so, we have to run the following commands in the folder VelibLibraryDeployment/src where there is the Dockerfile
```shell
docker build -t velibServer
```
which will take the instructions from the Dockerfile and build an image.
Then just run the command
```shell
docker run -p 8733:8733 velibServer
```
and the server is now running under mono and deployed on a docker container.

Then just run either the VelibClientGui.exe in the console VelibClientConsole/bin/Debug or the VelibClientConsole.exe in the VelibClientConsole/bin/Debug **(as administrator)** and send requests.

**Unfortunately** there is a remaining error that I didn't manage to resolve. This error prevents my server from correctly processing the request from the client, and it seems to be because of the basicHttpBinding. But the client efficiently sends a message to the IWS. SOAP seems to be hard to implements with mono.

## How to use the different applications

The projects below :

+ VelibClientConsole
+ VelibClientGui
+ VelibServerGui

Have to be launched from visual studio to work properly as the VelibLibrary won't be launched and the service won't be added outside Visual Studio.

### Remarks

I've added another empty Contract named AdminServices which implements the interface IAdminServices so that if someone has to continue developping the application to implement the Monitoring extension for example, he just has to add the operations he wants. Also, I've added a monitoring section in the VelibServerGui so that the administrator can manage cache and see the monitoring in the same application.

I had to change the binding when it came to implement the deployment extension because the communication between the client and the IWS with WSHttpBinding does not work with mono. Indeed mono doen't support a such binding. I had to go for a BasicHttpBinding instead.

# TD_Work

You will find in the folder named TD_Work the work done in the course sessions since the beginning.