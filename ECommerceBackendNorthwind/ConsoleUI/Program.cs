// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductManager productManager = new ProductManager(new EfProductDal());
CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

/*
foreach (var category in categoryManager.GetAll())
{
    Console.WriteLine(category.CategoryName);
}*/


foreach (var productDto in productManager.GetProductDetails())
{
    Console.WriteLine(productDto.ProductName + "/" + productDto.CategoryName);
}


