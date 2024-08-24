using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product{ProductId = 1, CategoryId = 1, ProductName = "Catal", UnitPrice = 5, UnitsInStock=20 },
            new Product{ProductId = 2, CategoryId = 1, ProductName = "Kasik", UnitPrice = 5, UnitsInStock=22},
            new Product{ProductId = 3, CategoryId = 2, ProductName = "Televizyon", UnitPrice = 5000, UnitsInStock=25},
            new Product{ProductId = 4, CategoryId = 2, ProductName = "Monitor", UnitPrice = 2500, UnitsInStock=23},
            new Product{ProductId = 5, CategoryId = 2, ProductName = "Klavye", UnitPrice = 500, UnitsInStock=13},
            }; 
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ usage to find ref value
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            if (productToDelete != null)
            {
                _products.Remove(productToDelete);
            }

            //maybe try catch is better for exception handling
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //find the product by id of the product with LINQ
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            if (productToUpdate != null)
            {
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
            }
        }
    }
}
