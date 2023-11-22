using HoixiBackend.Business.Abstract;
using HoixiBackend.DataAccess.Abstract;
using HoixiBackend.Entities.Concrete;
using HoixiBackend.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoixiBackend.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategory(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice <= max && p.UnitPrice >= min);
        }

        public List<ProductDetailDto> GetProductDetail()
        {
            return _productDal.GetProductDetail();
        }
    }
}
