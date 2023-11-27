# Online Mobile Catalog - a microservice-powered shopping portal 

A sample shopping website based on Microservices architecture. This application incorporates multiple microservices like:
- Catalog API 
- Basket API 
- Discount API 
- Order API 

that are aggregated using an Aggregator pattern. 

An API gateway exposes the relative endpoints for performing API actions like adding items to the basket, displaying the product catalogue and placing an order by calling the required microservice endpoint(s). The API gateway acts as a Backend for Front (BFF pattern) end that allows restricted access to the microservices only exposed via the gateway.

### Design patterns used in this Microservices architecture:

**Pattern Name:** `Project`

- **API Gateway:** `Ocelot.ApiGw`
- **Aggregator:** `Shopping.Aggregator`
- **Backend for Front-end:** `Shopping.Aggregator` 
- **Database per Service:** The `Basket`, `Catalog` and `Ordering` microservices have their own version of the database
- **Command Query Responsibility Segregation (CQRS):** `Ordering` microservice implements `CQRS` pattern internally
- **Mediator:** Ordering microservice uses `Mediator` pattern to fire commands and queries from the API controller to the application layer
- **Event-Driven Architecture:** The `Basket.API` project publishes events using `MassTransit` on `RabbitMQ` instance. Checkout action in `Ordering.API` is subscribed to the checkout fired event which as a result invokes `SendMail` action via the `EmailService`.

The UI part is a simple MVC website that communicates with the API gateway for performing portal operations like displaying and ordering products.

### Technologies and packages used:
- .NET Core 6
- Ocelot API gateway
- Rabbit MQ with Mass transit
- Docker containers
- Dapper
- Redis
- Mongo DB
- Protobuf with messages over gRPC
- Fluent Validations
- Entity Framework Core 7
- Automapper
- MediatR
