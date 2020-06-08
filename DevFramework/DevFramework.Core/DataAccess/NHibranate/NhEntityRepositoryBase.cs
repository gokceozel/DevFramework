using DevFramework.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using NHibernate.Linq;


namespace DevFramework.Core.DataAccess.NHibranate
{
    public class NhEntityRepositoryBase<TEntity>:IEntityRepository<TEntity> where TEntity:class,IEntity,new()
    {
        private NHibarnateHelper _nhibarnate;
        public NhEntityRepositoryBase(NHibarnateHelper nHibarnate)
        {
            _nhibarnate = nHibarnate;
        }

        public TEntity Add(TEntity entity)
        {
            using (var session= _nhibarnate.OpenSession())
            {
                session.Save(entity);
                return entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using(var session= _nhibarnate.OpenSession())
            {
                session.Delete(entity);
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var session=_nhibarnate.OpenSession())
            {
                return session.Query<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using(var session = _nhibarnate.OpenSession())
            {
                return filter == null ? session.Query<TEntity>().ToList() : session.Query<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Update(TEntity entity)
        {
            using(var session = _nhibarnate.OpenSession())
            {
                session.Update(entity);
                return entity;
            }
        }
    }
}
