using AcmeCurso.Domain;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCurso.Services
{
    public class ProfessorServiceDomain : IProfessorServiceDomain
    {
        private IProfessorRepository _professorRepository;
        public ProfessorServiceDomain(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }
        public void Add(Professor item)
        {
            _professorRepository.Add(item);
        }

        public void Update(Professor item)
        {
            _professorRepository.Update(item);
        }

        public void Delete(int id)
        {
            _professorRepository.Delete(id);
        }

        public IList<Professor> GetAll()
        {
            return _professorRepository.FilterBy(a => a.Id > 0, a => a.Curso).ToList();
        }

        public Professor GetById(int id)
        {
            return _professorRepository.FindById(id, a => a.Curso);
        }
    }
}
