using AcmeCurso.Domain;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCurso.Services
{
    public class EstudanteServiceDomain : IEstudanteServiceDomain
    {
        private IEstudanteRepository _estudanteRepository;
        public EstudanteServiceDomain(IEstudanteRepository estudanteRepository)
        {
            _estudanteRepository = estudanteRepository;
        }
        public void Add(Estudante item)
        {
            _estudanteRepository.Add(item);
        }

        public void Update(Estudante item)
        {
            _estudanteRepository.Update(item);
        }

        public void Delete(int id)
        {
            _estudanteRepository.Delete(id);
        }

        public IList<Estudante> GetAll()
        {
            return _estudanteRepository.FilterBy(a => a.Id > 0, a => a.Inscricoes, a => a.Inscricoes.Select(b => b.Curso)).ToList();
        }

        public Estudante GetById(int id)
        {
            return _estudanteRepository.FindById(id, a => a.Inscricoes, a => a.Inscricoes.Select(b => b.Curso));
        }
    }
}
