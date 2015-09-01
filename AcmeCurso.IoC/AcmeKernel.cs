using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCurso.IoC
{
     public class AcmeKernel : Ninject.StandardKernel
    {
         public AcmeKernel():base(new Module())
         {

         }
    }
}
