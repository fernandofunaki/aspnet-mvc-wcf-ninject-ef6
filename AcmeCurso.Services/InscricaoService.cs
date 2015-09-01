using AcmeCurso.Domain;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCurso.Services
{
    public class InscricaoServiceDomain : IInscricaoServiceDomain
    {
        private IInscricaoRepository _inscricaoRepository;
        public InscricaoServiceDomain(IInscricaoRepository inscricaoRepository)
        {
            _inscricaoRepository = inscricaoRepository;
        }
        public void Add(Inscricao item)
        {
            item.DataInscricao = DateTime.Now;
            _inscricaoRepository.Add(item);
        }

        public void Update(Inscricao item)
        {
            _inscricaoRepository.Update(item);
        }

        public void Delete(int id)
        {
            _inscricaoRepository.Delete(id);
        }

        public IList<Inscricao> GetAll()
        {
            return _inscricaoRepository.FilterBy(a => a.Id > 0, a => a.Estudante, a => a.Curso).ToList();
        }

        public Inscricao GetById(int id)
        {
            return _inscricaoRepository.FindById(id, a => a.Estudante, a => a.Curso);
        }
    }
}
