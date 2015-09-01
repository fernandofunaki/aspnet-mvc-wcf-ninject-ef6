using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCurso.Domain
{
    [DataContract(IsReference = true)]
    public abstract class Entity<TId> where TId : struct
    {
        [DataMember]
        public TId Id { get;  set; }

        [DataMember]
        public DateTime DataCriacao { get;  set; }

        public Entity()
        {
            this.DataCriacao = DateTime.Now;
        }
    }
}
