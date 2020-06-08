using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concree;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework
{
   public class EfProductDal: EfEntityRepository<Product,NorthwindContext>, IProductDal
    {
    }
}
