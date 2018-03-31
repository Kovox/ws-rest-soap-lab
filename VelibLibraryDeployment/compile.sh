#!/usr/bin/env bash

case "$(uname -s)" in

   CYGWIN*|MINGW*|MSYS*)
     csc src/*.cs -out:server.exe -r:src/Newtonsoft.Json.dll,src/System.ServiceModel.dll;;
     

   *)
     mcs src/*.cs -out:server.exe -r:src/Newtonsoft.Json.dll,src/System.ServiceModel.dll -pkg:wcf;;
     
esac
