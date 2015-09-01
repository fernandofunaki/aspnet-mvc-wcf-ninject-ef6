using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCurso.Repositories
{
    public class UnitOfWork<TContext> : IUnitOfWork
          where TContext : IContext, new()
    {

        private readonly IContext _context;

        public UnitOfWork()
        {
            _context = new TContext();
        }
        public UnitOfWork(IContext context)
        {
            _context = context;
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public IContext Context
        {
            get { return this._context; }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
