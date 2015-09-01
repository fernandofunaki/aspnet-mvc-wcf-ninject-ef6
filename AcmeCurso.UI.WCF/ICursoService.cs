using AcmeCurso.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcmeCurso.UI.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICursoService" in both code and config file together.
    [ServiceContract]
    public interface ICursoService
    {
        [OperationContract]
        void Add(Curso item);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Update(Curso item);

        [OperationContract]
        Curso GetById(int id);

        [OperationContract]
        IList<Curso> GetAll();
    }
}
