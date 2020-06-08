﻿using DevFramework.Northwind.Entities.Concree;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        public NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
        }
        public DbSet<Product>   Products { get; set; }
        public DbSet<Category>  Categories { get; set; }
    }
}
