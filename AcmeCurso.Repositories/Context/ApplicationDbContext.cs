using AcmeCurso.Domain;
using Domain;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCurso
{
    public class ApplicationUser : IdentityUser
    {
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IContext
    {
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Inscricao> Inscricao { get; set; }
        public DbSet<Estudante> Estudante { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
            base.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;
            base.Configuration.AutoDetectChangesEnabled = true;
            base.Configuration.EnsureTransactionsForFunctionsAndCommands = false;
            base.Configuration.ValidateOnSaveEnabled = false;
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
