using HoixiBackend.Core.DataAccess.EntityFramework;
using HoixiBackend.DataAccess.Abstract;
using HoixiBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoixiBackend.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal:EfEntityRepositoryBase<Order,HoixiBackendContext>,IOrderDal
    {
    }
}
