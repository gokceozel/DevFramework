using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.ComplexTypes;
using DevFramework.Northwind.Entities.Concree;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepository<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetail> GetProductWithCategoryName()
        {
            using(NorthwindContext context=new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryID
                             select new ProductDetail()
                             {
                                 ProductId=p.ProductId,
                                 ProductName=p.ProductName,
                                 CategoryName=c.CategoryName
                                 
                             };
                return result.ToList();
            }
           
        }
    }
}
