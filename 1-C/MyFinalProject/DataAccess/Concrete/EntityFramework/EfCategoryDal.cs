using HoixiBackend.Core.DataAccess.EntityFramework;
using HoixiBackend.DataAccess.Abstract;
using HoixiBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HoixiBackend.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, HoixiBackendContext>, ICategoryDal
    {
        
    }
}
