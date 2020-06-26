using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;
using DevFramework.Northwind.DataAccess.Concrete.NHibernate;
using DevFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Cryptography.X509Certificates;

namespace DevFramework.DataAccess.Tests.NHibernateTests
{
    [TestClass]
    public class NHibernateTest
    {
        //testlerden gecmesi için virtual key wordu gerekebilir.
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());
            var result = nhProductDal.GetList();
            Assert.AreEqual(77, result.Count);

        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_products()
        {
            NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());
            var result = nhProductDal.GetList(x=>x.ProductName.Contains("ab"));
            Assert.AreEqual(4, result.Count);
       }

        [TestMethod]
        public void Get_all_returns_all_categories()
        {
            NhCategoryDal nhCategoryDal = new NhCategoryDal(new SqlServerHelper());
            var result = nhCategoryDal.GetList();
            Assert.AreEqual(8, result.Count);

        }
        [TestMethod]
        public void Get_all_returns_all_categoriesProduct()
        {
            NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());
            var result = nhProductDal.GetProductDetails();
            Assert.AreEqual(77, result.Count);

        }
    }
}
