using AcmeCurso.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IInscricaoServiceDomain
    {
        void Add(Inscricao item);

        void Update(Inscricao item);

        void Delete(int id);

        IList<Inscricao> GetAll();

        Inscricao GetById(int id);
    }
}
