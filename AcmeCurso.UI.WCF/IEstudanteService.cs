using AcmeCurso.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcmeCurso.UI.WCF
{
    [ServiceContract]
    public interface IEstudanteService
    {
        [OperationContract]
        void Add(Estudante item);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Update(Estudante item);

        [OperationContract]
        Estudante GetById(int id);

        [OperationContract]
        IList<Estudante> GetAll();
    }
}
