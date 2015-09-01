using AcmeCurso.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface ICursoRepository :
        IAddRepository<Curso, int>,
        IUdapteRepository<Curso, int>,
        IDeleteRepository<int>,
        IReadSingleRepository<Curso,int>,
        IFilterRepository<Curso, int>
    {
    }
}
