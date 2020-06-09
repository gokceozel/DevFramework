using DevFramework.Core.DataAccess.NHibranate;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concree;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Northwind.DataAccess.Concrete.NHibernate
{
   public  class NhProductDal : NhEntityRepositoryBase<Product> ,IProductDal
    {
        public NhProductDal(NHibarnateHelper nHibarnateHelper):base(nHibarnateHelper)
        {

        }
    }
}
