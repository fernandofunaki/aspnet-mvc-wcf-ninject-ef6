using AcmeCurso.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IProfessorServiceDomain
    {
        void Add(Professor item);

        void Update(Professor item);

        void Delete(int id);

        IList<Professor> GetAll();

        Professor GetById(int id);
    }
}
