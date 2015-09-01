using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCurso.Domain
{
    public interface IDeleteRepository<TId>
        where TId : struct
    {
        void Delete(TId id);
    }
}
