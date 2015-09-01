using AcmeCurso.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IInscricaoRepository :
       IAddRepository<Inscricao, int>,
        IUdapteRepository<Inscricao, int>,
        IDeleteRepository<int>,
        IReadSingleRepository<Inscricao, int>,
        IFilterRepository<Inscricao, int>
    {
    }
}
