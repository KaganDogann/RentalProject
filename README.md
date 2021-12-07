# RentalProject

The project was developed in C#, in accordance with the multi-layered architecture and SOLID principles. CRUD operations were performed using the Entity Framework. MSSQL Localdb was used for database in the project. This system includes authentication and authorization. Users can only perform transactions for which they are authorized. Implementations of JWT; Transaction, Cache, Validation and Performance aspects have been implemented. Fluent Validation support for Validation, Autofac support for IoC added. The project includes CRUD operations for car, brand, color, car images, user, operations claim, user operation claims, customer, credit card and rental. Car rental is carried out according to certain business rules. In addition, findeks scores increase according to the users' car rentals. Each car has its own findeks score. The user must have enough Findeks points to rent a car.

# Layers
- Core : The core layer of the project is used for universal operations.
- DataAccess : It is the layer that connects the project with the Database.
- Entities: Our tables in the database have been created as objects in our project. It also contains DTO objects.
- Business : It is the business layer of our project. Various business rules; Data controls, validations and authorization controls
- WebAPI : It is the Restful API Layer of the project. Known methods: Get, Post, Put, Delete
# Used Technologies
- .Net Core 3.1
- Restful API
- Result Types
- Interceptor
- Autofac
- AOP, Aspect Oriented Programming
- Caching
- Performance
- Transaction
- Validation
- Fluent Validation
- Cache Management
- JWT Authentication
- Repository Design Pattern
- Cross Cutting Concerns
- Caching
- Validation
- Extensions
- Claim
- Exception Middleware
- Service Collection
- Error Handling
- Validation Error Details
