﻿using DevFramework.Core.DataAccess;
using DevFramework.Northwind.Entities.Concree;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Northwind.DataAccess.Abstract
{
   public  interface ICategoryDal : IEntityRepository<Category>
    {
        
    }
}