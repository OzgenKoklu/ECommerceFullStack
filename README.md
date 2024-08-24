# ECommerceFullStack
 E-Commerce website with backend & frontend

Learning Project for full stack development. Strictly follows the course material to have a grasp on enterprise architecture. https://www.kodlama.io/p/yazilim-gelistirici-yetistirme-kampi

Showcase for: 
-Enterprise architecture, DataAccess, Core, Business, Entity
-Usage of interfaces. Eg: IEntity, IProductdal, Generic Repository Design Pattern - Add(T entity) 
-Linq usage: 
ex: Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
Linq.Expressions :    List<T> GetAll(Expression<Func<T,bool>> filter =null);




Reference: Engin Demiroğ - Kodlama.io 