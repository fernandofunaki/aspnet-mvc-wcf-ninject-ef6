using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AcmeCurso.Domain
{
    [DataContract]
    public class Inscricao : Entity<int>
    {
        [DataMember]
        public virtual Curso Curso { get; set; }
        [DataMember]
        public int CursoId { get; set; }
        [DataMember]
        public DateTime DataInscricao { get; set; }
        [DataMember]
        public int EstudanteId { get; set; }
        [DataMember]
        public virtual Estudante Estudante { get; set; }

        public Inscricao()
        {

        }
    }
}
