using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCurso.Domain
{
    public interface IReadSingleRepository<TEntity, TId>
        where TId : struct
        where TEntity : Entity<TId>
    {
        TEntity FindById(TId id, params Expression<Func<TEntity, object>>[] includeProperties);
    }
}
