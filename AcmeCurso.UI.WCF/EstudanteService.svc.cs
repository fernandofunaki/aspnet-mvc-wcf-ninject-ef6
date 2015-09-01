using AcmeCurso.Domain;
using AcmeCurso.Repositories;
using AcmeCurso.Services;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcmeCurso.UI.WCF
{
    public class EstudanteService : IEstudanteService
    {
        private IUnitOfWork _uow;
        private IEstudanteServiceDomain _estudanteService;
        public EstudanteService(IUnitOfWork uow, IEstudanteServiceDomain estudanteService)
        {
            _uow = uow;
            _estudanteService = estudanteService;
        }
        public void Add(Estudante item)
        {
            try
             {
                _estudanteService.Add(item);
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
                _estudanteService.Delete(id);
                _uow.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Estudante item)
        {
            try
            {
                _estudanteService.Update(item);
                _uow.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Estudante> GetAll()
        {
            IList<Estudante> result = null;
            try
            {
                result = _estudanteService.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        Estudante IEstudanteService.GetById(int id)
        {
            Estudante result = null;
            try
            {
                result =  _estudanteService.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
