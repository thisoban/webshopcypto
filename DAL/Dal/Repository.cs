using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Database;


namespace Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        private readonly MyContext _context;
        public Repository() => _context = new MyContext();
        public virtual bool Create(TEntity entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public virtual bool Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            throw new NotImplementedException();
        }

        public virtual TEntity GetEntity(TEntity entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException($"{nameof(GetEntity)} entity must not be null");
            }
            throw new NotImplementedException();
        }

        public virtual List<TEntity> GetList(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual bool Update(TEntity entity)
        {
            bool updated = false;

            if (entity != null)
            {
                _context.Update(entity);
                updated = true;
            }

            return updated;
            throw new NotImplementedException();
        }
    }
}
