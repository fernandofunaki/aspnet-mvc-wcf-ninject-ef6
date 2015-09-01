using AcmeCurso.Domain;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcmeCurso.UI.WCF
{

    public class CursoService : ICursoService
    {
        private ICursoServiceDomain _cursoServiceDomain;
        private IUnitOfWork _uow;
        public CursoService(IUnitOfWork uow, ICursoServiceDomain cursoServiceDomain)
        {
            _uow = uow;
            _cursoServiceDomain = cursoServiceDomain;
        }

        public void Add(Domain.Curso item)
        {
            try
            {
                _cursoServiceDomain.Add(item);
                _uow.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                _cursoServiceDomain.Delete(id);
                _uow.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Curso item)
        {
            try
            {
                _cursoServiceDomain.Update(item);
                _uow.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Curso GetById(int id)
        {
            Curso result = null;
            try
            {
                result = _cursoServiceDomain.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public IList<Curso> GetAll()
        {
            IList<Curso> result = null;
            try
            {
                result = _cursoServiceDomain.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
