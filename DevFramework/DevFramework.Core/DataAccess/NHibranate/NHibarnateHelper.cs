using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Core.DataAccess.NHibranate
{
    public abstract class NHibarnateHelper : IDisposable
    {
        private static ISessionFactory _sessionFactory;

        public virtual ISessionFactory SessionFactory
        {
            get { return _sessionFactory ?? (_sessionFactory = InitializeFactory()); }
        }

        protected abstract ISessionFactory InitializeFactory();//ÇALIŞAN VERİ TABANINA GÖRE YAPILACAK İMPLEMANTASYON

        public virtual ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
