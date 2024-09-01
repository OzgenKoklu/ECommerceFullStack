# ECommerceFullStack
 E-Commerce website with backend & frontend

Learning Project for full stack development. Strictly follows the course material to have a grasp on enterprise architecture. https://www.kodlama.io/p/yazilim-gelistirici-yetistirme-kampi

!!! README WORK IN PROGRESS !!!
Showcase for: 
-Enterprise architecture, DataAccess, Core, Business, Entity
-Usage of interfaces. Eg: IEntity, IProductdal, Generic Repository Design Pattern - Add(T entity) 
-Linq usage: 
ex: Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
Linq.Expressions :    List<T> GetAll(Expression<Func<T,bool>> filter =null);
-Generic Constraint IEntityRepository<T> where T:class //sınırlama
-Entity Framework - Object relational mapping -  Linq destekli . 
-Working with Nuget packages: Entity Framework Sql Server , 

-ORM basics > DbContext
-IDisposable pattern for garbage collector using(Northwindcontext){}
-Core Layer for database non-specific codes for minimum repetition
-DTO's for joining SQL tables 
-Results for requests/responses (success and error results for data and no data, multiple constructors - Result(bool success, string message ): this(bool success)  - Result(bool succes)  
-ASP.Net Core Web Api - Restful architecture / json format - get/post etc - postman usage 
-Autofac for IoC container,
-Fluent validation
-Aspect oriented programming using Autofac 
-JWT creation/ Authorization, claims 
-Hashing & use of System.Security.Cryptograpgy
-Class Extensions - E.g.: ClaimExtensions, ClaimsPrincipalExtensions.
-ServiceCollection extending for dependency injection for Aspects**

-Angular Frontent 
Bootstrap for styling
Data handling for frontend



!!! README WORK IN PROGRESS !!!

Reference: Engin Demiroğ - Kodlama.io 