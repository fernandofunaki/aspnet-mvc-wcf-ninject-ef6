using AcmeCurso.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IEstudanteServiceDomain
    {
        void Add(Estudante item);

        void Update(Estudante item);

        void Delete(int id);

        IList<Estudante> GetAll();

        Estudante GetById(int id);
    }
}
