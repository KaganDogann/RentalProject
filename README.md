# RentalProject
ReCapProject - Rent A Car Project
A car rental project developed with C# and .Net Core Framework. In development phase, N-Layered Architecture model was followed. You can perform basic CRUD operations with this program. Also, this program has JWT Bearer system. CRUD operaitons will work if the user has right claims.

Layers
Core : The core layer of the project is used for universal operations.
DataAccess : It is the layer that connects the project with the Database.
Entities: Our tables in the database have been created as objects in our project. It also contains DTO objects.
Business : It is the business layer of our project. Various business rules; Data controls, validations and authorization controls
WebAPI : It is the Restful API Layer of the project. Known methods: Get, Post, Put, Delete
Used Technologies
.Net Core 3.1
Restful API
Result Types
Interceptor
Autofac
AOP, Aspect Oriented Programming
Caching
Performance
Transaction
Validation
Fluent Validation
Cache Management
JWT Authentication
Repository Design Pattern
Cross Cutting Concerns
Caching
Validation
Extensions
Claim
Exception Middleware
Service Collection
Error Handling
Validation Error Details
