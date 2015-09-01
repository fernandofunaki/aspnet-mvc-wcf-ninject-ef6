using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCurso.Domain
{
    [DataContract]
    public class Estudante : Entity<int>
    {
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Sobrenome { get; set; }
        [DataMember]
        
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime DataMatricula { get; set; }

        [DataMember]
        [UIHint("_Inscricoes")]
        public virtual ICollection<Inscricao> Inscricoes { get; set; }

        public Estudante()
        {

        }
    }
}
