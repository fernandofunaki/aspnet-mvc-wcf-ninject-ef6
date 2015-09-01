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
    public interface IProfessorService
    {
        [OperationContract]
        void Add(Professor item);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Update(Professor item);

        [OperationContract]
        Professor GetById(int id);

        [OperationContract]
        IList<Professor> GetAll();
    }
}
