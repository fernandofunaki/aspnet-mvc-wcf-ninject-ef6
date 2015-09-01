using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCurso.Domain
{
    [DataContract]
    public class Curso : Entity<int>
    {
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Descricao { get; set; }
        [DataMember]
        public DateTime DataLimiteInscricao { get; set; }
        [DataMember]
        public ICollection<Inscricao> Inscricoes { get; set; }

        public Curso()
        {

        }
    }
}
