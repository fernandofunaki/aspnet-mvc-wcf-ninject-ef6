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
    public class EstudanteRepository :  IEstudanteRepository
    {
        private DbContext _context;
        public EstudanteRepository(IUnitOfWork uow)
        {
            this._context = uow.Context as DbContext;
        }

        public void Add(Domain.Estudante entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Added;
        }

        public void Update(Domain.Estudante entity)
        {
            var item = FindById(entity.Id);
            _context.Entry(item).CurrentValues.SetValues(entity);
        }

        public void Delete(int id)
        {
            var item = FindById(id);
            _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
        }

        public Domain.Estudante FindById(int id, params Expression<Func<Domain.Estudante, object>>[] includes)
        {
            IQueryable<Domain.Estudante> query = _context.Set<Domain.Estudante>();
            foreach (var includeProperty in includes)
            {
                query = query.Include(includeProperty);
            }
            return query.FirstOrDefault(a => a.Id == id);
        }

        public IQueryable<Domain.Estudante> FilterBy(Expression<Func<Domain.Estudante, bool>> expression, params Expression<Func<Domain.Estudante, object>>[] includes)
        {
            IQueryable<Domain.Estudante> query = _context.Set<Domain.Estudante>();
            foreach (var includeProperty in includes)
            {
                query = query.Include(includeProperty);
            }
            return query.AsNoTracking();
        }
    }
}
