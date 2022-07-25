How to set up Code Challenge 1


Please Install the code from the following link 
https://github.com/Lexxie25/CodeChallenges.git 

There are 3 feature branches for each project please select the appropriate one for each project.
cupswap 
albums
feature3

You can download the code by cloning the GitRepository link onto your local machine or download as a zip file. 

Once unzipped or cloned please open Visual Studio. 
I used Visual Studio 2022. With .Net 6 and C# as my foundation of this web API. on a Windows 11 system. If you are using a different os system this may not be the same steps.

You will also need Docker on your local machine. 
If you do not have it installed yet please go to https://docs.docker.com/get-started/
And follow the startup information for your computer. 

Once the project is up I will create a gitIgnore as Github does not have a boilerplate file for .Net. 
I will add to the gitignore file at the very last line of it. The following code. 

##
## Docker Compose
##
docker-compose.override.yml

This is a good practice as you may have secrets in this file that you do not want to be on Github. 

With the project open in Visual Studio please right click on your Api project in the solutions bar. Go to Add and look for Container Orchestrator support. Please select this for docker compose to manage the containers.

Once loaded I will go in and add ports to the compose file. To make sure that they are on clean ports for the project and there's not anything else on the base ports. And I will add a name to the container to make it easier to see. 
In the services I will add containte_name and set that to my API name . 

And port 80 and 443 I will map to ports that I know are free. Usually in the 35000 range. 
The code below is from the API’s docker-compose.yml file 

version: '3.4'

services:
  codechallenge.api:
    image: ${DOCKER_REGISTRY-}codechallengeapi
    container_name: "Codechallenge.api"
    build:
      context: .
      dockerfile: CodeChallenge.Api/Dockerfile
    ports:
      - "35020:80"
      - "35021:443"
 
After that is all done you should be up and running to access the feature branches and run the code. 


API endpoints are as followed 

Feature 1  cupswap  can be found at https://localhost:35020/api/cups/swap
Feature 2 albums can be found at https://localhost:35020/api/albums

Feature 3 is located at the route of the project. 
