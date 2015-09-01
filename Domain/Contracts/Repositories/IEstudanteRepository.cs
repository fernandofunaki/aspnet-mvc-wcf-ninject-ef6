using AcmeCurso.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IEstudanteRepository : 
        IAddRepository<Estudante, int>,
        IUdapteRepository<Estudante, int>,
        IDeleteRepository<int>,
        IReadSingleRepository<Estudante, int>,
        IFilterRepository<Estudante, int>
    {
    }
}
