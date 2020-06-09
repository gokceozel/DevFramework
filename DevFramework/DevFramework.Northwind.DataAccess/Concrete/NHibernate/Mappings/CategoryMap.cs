using DevFramework.Northwind.Entities.Concree;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Northwind.DataAccess.Concrete.NHibernate.Mappings
{
   public  class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"Categories");
            LazyLoad();
            Id(x => x.CategoryID).Column("CategoryID");//primary key alanı
            Map(x => x.CategoryName).Column("CategoryName");
        }
    }
}
