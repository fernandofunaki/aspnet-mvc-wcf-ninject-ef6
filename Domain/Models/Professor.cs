using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCurso.Domain
{
    [DataContract]
    public class Professor : Entity<int>
    {
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Sobrenome { get; set; }
        [DataMember]
        public string Titulacao { get; set; }
        [DataMember]
        public int CursoId { get; set; }
        [DataMember]
        public virtual Curso Curso { get; set; }

        public Professor()
        {

        }
    }
}
