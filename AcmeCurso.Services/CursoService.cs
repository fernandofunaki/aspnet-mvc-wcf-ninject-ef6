using AcmeCurso.Domain;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCurso.Services
{
    public class CursoServiceDomain : ICursoServiceDomain
    {
        private ICursoRepository _cursoRepository;
        public CursoServiceDomain(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }
        public void Add(Curso item)
        {
            _cursoRepository.Add(item);
        }

        public void Update(Curso item)
        {
            _cursoRepository.Update(item);
        }

        public void Delete(int id)
        {
            _cursoRepository.Delete(id);
        }

        public IList<Curso> GetAll()
        {
            return _cursoRepository.FilterBy(a => a.Id > 0).ToList();
        }

        public Curso GetById(int id)
        {
            return _cursoRepository.FindById(id);
        }
    }
}
