// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductManager productManager = new ProductManager(new EfProductDal()
                , new CategoryManager(new EfCategoryDal()));


CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());


foreach (var category in categoryManager.GetAll().Data)
{
    Console.WriteLine(category.CategoryName);
}

 foreach (var productDto in productManager.GetProductDetails().Data)
{
    Console.WriteLine(productDto.ProductName + "/" + productDto.CategoryName);
}

var result = productManager.GetProductDetails();

//Console.WriteLine(result.Success.ToString());
if (result.Success == true)
{
    foreach (var product in result.Data)
    {
        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
    }
}
else
{
    Console.WriteLine(result.Message);
}