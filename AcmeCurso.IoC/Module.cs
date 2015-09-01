using AcmeCurso.Repositories;
using AcmeCurso.Services;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCurso.IoC
{
    public class Module : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            base.Bind<IContext>().To<ApplicationDbContext>().InSingletonScope();
            base.Bind<IUnitOfWork>().To<UnitOfWork<ApplicationDbContext>>().InSingletonScope();

            base.Bind<IEstudanteRepository>().To<EstudanteRepository>();
            base.Bind<IInscricaoRepository>().To<InscricaoRepository>();
            base.Bind<IProfessorRepository>().To<ProfessorRepository>();
            base.Bind<ICursoRepository>().To<CursoRepository>();

            base.Bind<IEstudanteServiceDomain>().To<EstudanteServiceDomain>();
            base.Bind<IInscricaoServiceDomain>().To<InscricaoServiceDomain>();
            base.Bind<IProfessorServiceDomain>().To<ProfessorServiceDomain>();
            base.Bind<ICursoServiceDomain>().To<CursoServiceDomain>();
        }
    }
}
