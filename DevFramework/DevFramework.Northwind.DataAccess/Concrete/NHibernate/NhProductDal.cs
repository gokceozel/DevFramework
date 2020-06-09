using DevFramework.Core.DataAccess.NHibranate;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.ComplexTypes;
using DevFramework.Northwind.Entities.Concree;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DevFramework.Northwind.DataAccess.Concrete.NHibernate
{
   public  class NhProductDal : NhEntityRepositoryBase<Product> ,IProductDal
    {
        private NHibarnateHelper _nHibarnateHelper;

        public NhProductDal(NHibarnateHelper nHibarnateHelper):base(nHibarnateHelper)
        {
            _nHibarnateHelper = nHibarnateHelper;
        }

        public List<ProductDetail> GetProductWithCategoryName()
        {
            using (var session=_nHibarnateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                             join c in session.Query<Category>()
                             on p.CategoryId equals c.CategoryID
                             select new ProductDetail()
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName
                             };

                return result.ToList();
            }
        }
    }
}
