using HoixiBackend.Entities.Concrete;
using HoixiBackend.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoixiBackend.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategory(int id);
        List<Product> GetByUnitPrice(decimal min,decimal max);
        List<ProductDetailDto> GetProductDetail();
        void Add(Product product);        
    }
}
