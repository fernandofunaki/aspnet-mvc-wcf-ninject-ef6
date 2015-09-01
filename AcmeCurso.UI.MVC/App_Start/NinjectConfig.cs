using Ninject;
using Ninject.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcmeCurso.UI.MVC.App_Start
{



    public class AcmeWcfServiceModule : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            base.Bind<WcfCursoService.ICursoService>().To<WcfCursoService.CursoServiceClient>();
            base.Bind<WcfEstudanteService.IEstudanteService>().To<WcfEstudanteService.EstudanteServiceClient>();
            base.Bind<WcfInscricaoService.IInscricaoService>().To<WcfInscricaoService.InscricaoServiceClient>();
            base.Bind<WcfProfessorService.IProfessorService>().To<WcfProfessorService.ProfessorServiceClient>();
        }
    }

    public class NinjectDependencyResolver : System.Web.Mvc.IDependencyResolver
    {
        private readonly IResolutionRoot _resolutionRoot;
        public NinjectDependencyResolver(IResolutionRoot kernel)
        {
            _resolutionRoot = kernel;
        }
        public object GetService(Type serviceType)
        {
            return _resolutionRoot.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _resolutionRoot.GetAll(serviceType);
        }

        public static void ConfigurarDependencias()
        {
            IKernel kernel = new StandardKernel();

            kernel.Load(new Ninject.Modules.INinjectModule[] { new AcmeWcfServiceModule() });

            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}