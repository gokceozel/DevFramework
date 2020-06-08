using DevFramework.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevFramework.Core.DataAccess.NHibranate
{
    public class NhQueryableRepository<TEntity> : IQueryableRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private NHibarnateHelper _nhibarnate;
        private IQueryable<TEntity> _entities;
        public NhQueryableRepository(NHibarnateHelper nHibarnate)
        {
            _nhibarnate = nHibarnate;
            
        }
        public IQueryable<TEntity> Table
        {
            get { return this.Enitites; }
        }

        public virtual IQueryable<TEntity> Enitites {
            get {
                if (_entities == null)
                {
                    _entities = _nhibarnate.OpenSession().Query<TEntity>();
                }
                return _entities;
             } 
        }
    }
}
