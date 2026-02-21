# Naming Conventions

## Repository
A Repository class is responsible for all communication with data storage, such as databases or files. It provides methods to fetch, save, update, or delete data, so the rest of your code does not need to know how the data is stored or retrieved. This keeps data access logic separate from business logic, making your code easier to maintain and test.

```csharp
public class UserRepository {
	public User GetUser(int id) { /* ... */ }
	public void SaveUser(User user) { /* ... */ }
}
```


## Service
A Service class contains the main business logic of your application. It performs operations, calculations, or decisions that are specific to your application's needs. Services use repositories to get or save data, but do not handle data storage directly. They focus on what your application does, not how data is stored or presented.

```csharp
public class PaymentService {
	public void ProcessPayment(Order order) { /* ... */ }
}
```


## Controller
A Controller class is the entry point for handling web requests (such as HTTP requests in a web API). It receives input from the user or client, validates it, calls the appropriate service methods, and returns a response. Controllers should not contain business logic or data access code—they simply coordinate the flow between the user, services, and data.

```csharp
public class UserController {
	public IActionResult Get(int id) { /* ... */ }
}
```


## DTO (Data Transfer Object)
A DTO is a simple class used to transfer data between different parts of an application, or between applications (such as over a network). DTOs only contain data—no logic—and are often used to shape or limit what data is sent or received, helping to keep internal models private and reduce accidental coupling between layers.

```csharp
public class UserDto {
	public int Id { get; set; }
	public string Name { get; set; }
}
```


## Entity / Model / Domain Model
An Entity, Model, or Domain Model represents a real-world thing or concept in your application's business logic, such as a user, product, or order. These classes define the properties and behaviours of these things and are used throughout your business logic to represent and manipulate real data.

```csharp
public class User {
	public int Id { get; set; }
	public string Name { get; set; }
}
```


## Handler
A Handler class is responsible for carrying out a single, specific action or command, such as creating an order or processing a payment. Handlers are often used in systems that follow the Command or Mediator patterns, where each handler does one job and is easy to test and reuse.

```csharp
public class CreateOrderHandler {
	public void Handle(CreateOrderCommand cmd) { /* ... */ }
}
```


## Factory
A Factory class is used to create objects, especially when the creation process is complex or involves several steps. Factories help keep object creation logic out of other classes, making your code cleaner and more flexible if the way objects are created changes in the future.

```csharp
public class UserFactory {
	public User Create(string name) { return new User { Name = name }; }
}
```


## Mapper
A Mapper class is responsible for converting one type of object to another, such as turning an Entity into a DTO or vice versa. This is useful when you need to move data between layers that use different representations, ensuring each layer only works with the data it needs.

```csharp
public class UserMapper {
	public UserDto ToDto(User user) { /* ... */ }
}
```


## Client
A Client class is used to communicate with external systems, such as web APIs, email servers, or third-party services. It contains methods for sending requests and handling responses, so the rest of your code does not need to know the details of how to communicate with these outside systems.

```csharp
public class EmailClient {
	public void Send(string to, string msg) { /* ... */ }
}
```


## Provider
A Provider class supplies data or services that come from the environment, configuration, or other sources outside your main application logic. For example, a provider might give you the current date and time, configuration settings, or user information from the operating system.

```csharp
public class DateTimeProvider {
	public DateTime Now => DateTime.UtcNow;
}
```
