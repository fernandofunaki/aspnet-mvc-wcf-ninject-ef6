using AcmeCurso.Domain;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AcmeCurso.UI.MVC.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    //public class ApplicationUser : IdentityUser
    //{
    //}

    //public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    //{
    //    public DbSet<Curso> Curso { get; set; }
    //    public DbSet<Professor> Professor { get; set; }
    //    public DbSet<Inscricao> Inscricao { get; set; }
    //    public DbSet<Estudante> Estudante { get; set; }

    //    public ApplicationDbContext()
    //        : base("DefaultConnection")
    //    {
    //        base.Configuration.LazyLoadingEnabled = true;
    //    }


    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    //        base.OnModelCreating(modelBuilder);
    //    }
    //}
}