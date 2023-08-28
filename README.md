# Pastebin Task

## Task Description 
This technical task aims to validate your development skills and simplify the process of technical evaluation, as it covers different aspects of a developer's daily work. In this task, you will need to complete the implementation of a pastebin application. In this repository, you can find the project with all required resources.

### What is Pastebin?
Pastebin like services enable users to store plain text or images over the network (typically the Internet) and generate unique URLs to access the uploaded data. Such services are also used to share data over the network quickly, as users would just need to pass the URL to let other users see it.

If you haven’t used [pastebin.com](https://pastebin.com) before, please try creating a new ‘Paste’ there and spend some time going through the different options their service offers. This will help you a lot in understanding this task.

## Pastebin requirements

### Functional Requirements:
- Users should be able to upload or “paste” their data and get a unique URL to access it.
- Users will only be able to upload text.
- User can see list of own pastebins.
- Add User logout functionality
#### Additional functionality to consider:
- Data and links will expire after a specific timespan automatically; users should also be able to specify expiration time.
- Users should optionally be able to pick a custom alias for their paste.

### Non-Functional Requirements:
- Users should be able to access their Pastes in real-time with minimum latency.
- Paste links should not be guessable (not predictable).
- Our application should be traceable.
- Write at least few tests to cover functionality of the app.

### During implementation please pay attention to:
- Application is runnable out of box. If some setup is needed please provide details on ReadMe file.
- Project structure and code smells.
- Design Principles and application testability.
- Main focus should be on backend functionality, not UI.
- Input parameter validation.
- Please, don't use any library or service that implements the core functionality of this test.

### Other recommendation:
- You may change UI technology to any other you are most familiar with.
- Analytics, e.g., how many times a paste was accessed?
- During task implantation only code inside of Pastebin folder is aimed to be changes. But be free to modify any part of this repo. Don't forget to provide short description of your changes.

## Source code explanations

In the repo we have multiple solutions that covers different aspect of Pastebin application. It contains docker compose file so you should be able to easily run application on you machine.

### Repository Overview
- Pastebin.sln - Is an entry point for development. All 
- src - Source projects that include Pastebin application and Identity Server.
- tests - Tests projects
- docker-compose-cmd.yaml - Stand-alone Docker compose configuration you can use it outside of Visual Studio. but bear in mind that preferable method to run application is from Visual Studio debugger which gonna use docker-compose.yml file.

### Solution Overview

All projects placed in one solution to keep it minimal land simplify debugging process. 

Solution contains docker-compose configuration that will spin all required services. 

- https://localhost:8090 - Pastebin application
- https://localhost:8086 - Identity Server
- http://localhost:8080 - Postgres Admin. User: postgres  Password: 1+1is2
- localhost:5432 - Postgres Server. Connection string 'User ID =postgres;Password=1+1is2;Server=localhost;Port=5432;Database=PastebinDB;Integrated Security=true;Pooling=true;'


#### In TODO
- Pastebin.UI.React - React SPA. If you prefer to use React you can use this project for your UI implementation.
- Pastebin.UI.Angular - Angular SPA. If you prefer to use React you can use this project for your UI implementation.

## Submitting result 
- Create private repo with your solution and share access with TE evaluator. 
- Pay attention to Functional and Non-functional requirements.
- Provide short description in readme file: 

### How to start?
`Section description:  What should be done before application start(e.g db migration)`

### Key assumptions 
`Section description: If you have any assumption during your implementation, please provide them here.`

### Future Ideas
`Section description:  If you haven't enough time to implement some feature or ideas, please provide them here.`

# May the force be with you {username}!