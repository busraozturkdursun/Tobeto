using HoixiBackend.Business.Concrete;
using HoixiBackend.DataAccess.Concrete.EntityFramework;
using System.Runtime.InteropServices;


ProductTest();
CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetProductDetail())
    {
        Console.WriteLine("Ürün İsmi : " + product.ProductName + " | Ürün Kategorisi : " + product.CategoryName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}