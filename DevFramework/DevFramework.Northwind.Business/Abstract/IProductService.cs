using DevFramework.Northwind.Entities.Concree;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Northwind.Business.Abstract
{
   public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        Product Add(Product product);
        Product Update(Product product);
    }
}
