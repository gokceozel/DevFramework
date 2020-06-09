
using DevFramework.Core.DataAccess.NHibranate;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DevFramework.Northwind.DataAccess.Concrete.NHibernate.Helper
{
    public class SqlServerHelper : NHibarnateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            throw new NotImplementedException();
        }

    }
}
