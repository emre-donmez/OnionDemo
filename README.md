## What is Onion Architecture?

Onion Architecture is a design approach that organizes software projects into layers, each with a specific responsibility. This architecture divides the project into different layers, and each layer has a specific responsibility. The layers in the OnionDemo project are as follows:

- **Domain:** This is where the business logic of the project is defined. It includes entities, value objects, and domain services.

- **Application:** Implements use cases and coordinates the flow of data between the domain and infrastructure layers.

- **Application.Abstraction:** This layer contains interfaces and abstractions of the application layer. It facilitates communication between the application layer and other layers.

- **Infrastructure:** The infrastructure layer manages access to external resources external services.

- **Persistence:** This layer performs database operations. Database interactions using Entity Framework are defined here.

- **Presentation** 
	- **WebApi:** This layer provides RESTful services.
	- **UI:**  This layer manages user interface interactions. It is independent from other layers and provides data access via web API.


## OnionDemo Project

OnionDemo is an ASP.NET Core project developed using the Onion architecture. This project is designed with clean code principles and utilizes generic classes. 

This project includes two pages.
- **Category Page**: It communicates with WebApi via ajax.
- **Product Page**: It communicates with WebApi via using ApiRequestHelper class.  

## How to Use
1. Clone the project files to your computer.
2. Update the database connection settings in the appsettings.json file.
3. To update the database, use the following command in package manager console:     
        
```
Update-Database -Project Infastructure\OnionDemo.Persistence -StartupProject Presentation\OnionDemo.WebApi 
```
