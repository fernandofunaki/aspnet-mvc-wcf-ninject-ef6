using AcmeCurso.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface ICursoServiceDomain
    {
        void Add(Curso curso);

        void Update(Curso curso);

        void Delete(int id);

        IList<Curso> GetAll();

        Curso GetById(int id);
    }
}
