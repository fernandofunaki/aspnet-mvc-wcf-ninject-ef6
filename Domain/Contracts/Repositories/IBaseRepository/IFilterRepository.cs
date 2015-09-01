using AcmeCurso.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IFilterRepository<TEntity, TId>
        where TId : struct
        where TEntity : Entity<TId>
    {
        IQueryable<TEntity> FilterBy(Expression<System.Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includeProperties);
    }
}
