# E-Commerce FullStack

An E-Commerce website built with a full stack development approach, including both backend and frontend components. This project strictly follows course material to understand enterprise architecture effectively. For more details, refer to the [course link](https://www.kodlama.io/p/yazilim-gelistirici-yetistirme-kampi).

## Project Overview

### Backend: .NET Core

The backend is developed using .NET Core and showcases several enterprise architecture concepts and design patterns:

- **Enterprise Architecture**: Organized into Data Access, Core, Business, and Entity layers.
- **Usage of Interfaces**: Implementing interfaces such as `IEntity`, `IProductDal`, and the Generic Repository Design Pattern (`Add(T entity)`).
- **LINQ Usage**: Examples include filtering and selecting data, e.g., `Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);`.
- **LINQ Expressions**: Generic filtering using expressions, e.g., `List<T> GetAll(Expression<Func<T, bool>> filter = null);`.
- **Generic Constraints**: Applying constraints, e.g., `IEntityRepository<T> where T : class`.
- **Entity Framework**: Object-Relational Mapping (ORM) with LINQ support, basic ORM concepts like `DbContext`.
- **IDisposable Pattern**: Used for garbage collection, e.g., `using (NorthwindContext) {}`.
- **Core Layer**: Contains database-agnostic code to minimize repetition.
- **DTOs (Data Transfer Objects)**: Used for joining SQL tables and transferring data.
- **Result Handling**: Custom result classes for handling requests and responses (success and error results for both data and non-data scenarios).
- **ASP.NET Core Web API**: RESTful architecture with JSON format support for GET/POST operations, demonstrated using Postman.
- **Autofac for IoC (Inversion of Control) Container**: Managing dependencies and supporting aspect-oriented programming.
- **Fluent Validation**: For input validation.
- **Aspect-Oriented Programming**: Implemented using Autofac.
- **JWT (JSON Web Tokens) for Authentication**: Handling authorization and claims.
- **Hashing**: Utilizes `System.Security.Cryptography` for secure hashing.
- **Class Extensions**: Includes examples like `ClaimExtensions`, `ClaimsPrincipalExtensions`.
- **ServiceCollection Extensions**: For dependency injection, particularly for Aspects.
- **Middleware Usage**: For error handling and validation errors.
- **Caching**: Implemented cache aspect for performance optimization.

### Frontend: Angular

The frontend is developed using Angular with several features:

- **Bootstrap**: For styling and responsive design.
- **Data Handling**: Efficient data management on the frontend.
- **Angular Routing**: For navigation between different pages.
- **Pipes and Filters**: Data transformation using Angular Pipes and filters.
- **Forms Module**: Usage of `ngModel`, "banana in a box" notation, and FormBuilder.
- **Toastr for Notifications**: On-screen notifications for user interactions.
- **Data Addition through Forms**: Utilizing FormBuilder to add data to the database.
- **Authentication and Authorization**: Handling login and tokens using local storage, interceptors for token tracking, and guards for route protection.

### References

- Engin Demiroğ - [Kodlama.io](https://www.kodlama.io/courses/1235979/)
