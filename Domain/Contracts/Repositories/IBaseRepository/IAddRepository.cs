using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCurso.Domain
{
    public interface IAddRepository<TEntity, TId> 
        where TId : struct
        where TEntity : Entity<TId>
    {
        void Add(TEntity entity);
    }
}
