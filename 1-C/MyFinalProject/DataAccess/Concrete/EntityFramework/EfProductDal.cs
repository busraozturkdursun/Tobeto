using HoixiBackend.Core.DataAccess.EntityFramework;
using HoixiBackend.DataAccess.Abstract;
using HoixiBackend.Entities.Concrete;
using HoixiBackend.Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HoixiBackend.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, HoixiBackendContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetail()
        {
            using (HoixiBackendContext context = new HoixiBackendContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryID
                             select new ProductDetailDto { ProductId= p.ProductID, 
                                 CategoryName= c.CategoryName,
                                 ProductName = p.ProductName, 
                                 UnitsInStock = p.UnitsInStock };
                return result.ToList();
            }
        }
    }
}
