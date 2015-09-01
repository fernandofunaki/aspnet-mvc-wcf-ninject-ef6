using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Ninject.Web.Common;
using Ninject;
using AcmeCurso.IoC;


namespace AcmeCurso.UI.WCF
{
    public class Global : Ninject.Web.Common.NinjectHttpApplication
    {
        protected override Ninject.IKernel CreateKernel()
        {
            return new StandardKernel(new Module());
        }
    }
}