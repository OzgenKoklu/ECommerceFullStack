# ECommerceFullStack
 E-Commerce website with backend & frontend

Learning Project for full stack development. Strictly follows the course material to have a grasp on enterprise architecture. https://www.kodlama.io/p/yazilim-gelistirici-yetistirme-kampi

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

Reference: Engin Demiroğ - Kodlama.io 