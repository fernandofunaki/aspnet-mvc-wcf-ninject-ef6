using AcmeCurso.Domain;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCurso.Repositories
{
    public class InscricaoRepository : IInscricaoRepository
    {
        private DbContext _context;
        public InscricaoRepository(IUnitOfWork uow)
        {
            this._context = uow.Context as DbContext;
        }

        public void Add(Domain.Inscricao entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Added;
        }

        public void Update(Domain.Inscricao entity)
        {
            var item = FindById(entity.Id);
            _context.Entry(item).CurrentValues.SetValues(entity);
        }

        public void Delete(int id)
        {
            var item = FindById(id);
            _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
        }

        public Domain.Inscricao FindById(int id, params Expression<Func<Domain.Inscricao, object>>[] includes)
        {
            IQueryable<Domain.Inscricao> query = _context.Set<Domain.Inscricao>();
            foreach (var includeProperty in includes)
            {
                query = query.Include(includeProperty);
            }
            return query.FirstOrDefault(a => a.Id == id);
        }

        public IQueryable<Domain.Inscricao> FilterBy(Expression<Func<Domain.Inscricao, bool>> expression, params Expression<Func<Domain.Inscricao, object>>[] includes)
        {
            IQueryable<Domain.Inscricao> query = _context.Set<Domain.Inscricao>();
            foreach (var includeProperty in includes)
            {
                query = query.Include(includeProperty);
            }
            return query.Where(expression).AsNoTracking();
        }

    }
}
