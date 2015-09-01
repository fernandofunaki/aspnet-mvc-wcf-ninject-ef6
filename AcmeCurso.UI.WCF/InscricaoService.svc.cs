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
    public class InscricaoService : IInscricaoService
    {
        private IUnitOfWork _uow;
        private IInscricaoServiceDomain _inscricaoServiceDomain;
        public InscricaoService(IUnitOfWork uow, IInscricaoServiceDomain inscricaoServiceDomain)
        {
            _uow = uow;
            _inscricaoServiceDomain = inscricaoServiceDomain;
        }
        public void Add(Inscricao item)
        {
            try
            {
                _inscricaoServiceDomain.Add(item);
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
                _inscricaoServiceDomain.Delete(id);
                _uow.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Inscricao item)
        {
            try
            {
                _inscricaoServiceDomain.Update(item);
                _uow.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Inscricao GetById(int id)
        {
            Inscricao result = null;
            try
            {
                result = _inscricaoServiceDomain.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public IList<Inscricao> GetAll()
        {
            IList<Inscricao> result = null;
            try
            {
                result = _inscricaoServiceDomain.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
