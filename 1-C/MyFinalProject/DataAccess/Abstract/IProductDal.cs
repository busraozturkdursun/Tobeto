using HoixiBackend.Core.DataAccess;
using HoixiBackend.Entities.Concrete;
using HoixiBackend.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoixiBackend.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetail();
    }
}
