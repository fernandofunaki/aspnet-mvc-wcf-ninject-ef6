using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IContext : IDisposable
    {
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        int SaveChanges();
    }
}
