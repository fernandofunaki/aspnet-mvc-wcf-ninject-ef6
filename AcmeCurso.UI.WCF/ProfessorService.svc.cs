using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcmeCurso.UI.WCF
{

   public class ProfessorService : IProfessorService
    {
        private IProfessorServiceDomain _professorServiceDomain;
        private IUnitOfWork _uow;
        public ProfessorService(IUnitOfWork uow, IProfessorServiceDomain professorServiceDomain)
        {
            _uow = uow;
            _professorServiceDomain = professorServiceDomain;
        }

        public void Add(Domain.Professor item)
        {
            _professorServiceDomain.Add(item);
            _uow.SaveChanges();
        }

        public void Delete(int id)
        {
            _professorServiceDomain.Delete(id);
            _uow.SaveChanges();
        }

        public void Update(Domain.Professor item)
        {
            _professorServiceDomain.Update(item);
            _uow.SaveChanges();
        }

        public Domain.Professor GetById(int id)
        {
            return _professorServiceDomain.GetById(id);
        }

        public IList<Domain.Professor> GetAll()
        {
            return _professorServiceDomain.GetAll();
        }
    }
}
