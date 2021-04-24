using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        List<TEntity> GetList(TEntity entity);
        TEntity GetEntity(TEntity entity);
        bool Create(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
    }
}
