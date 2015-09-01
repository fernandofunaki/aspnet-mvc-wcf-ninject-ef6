using AcmeCurso.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IProfessorRepository :
            IAddRepository<Professor, int>,
        IUdapteRepository<Professor, int>,
        IDeleteRepository<int>,
        IReadSingleRepository<Professor, int>,
        IFilterRepository<Professor, int>
    {
    }
}
