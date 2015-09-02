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

    public class ProfessorRepository : IProfessorRepository
    {
        private DbContext _context;
        public ProfessorRepository(IUnitOfWork uow)
        {
            this._context = uow.Context as DbContext;
        }

        public void Add(Domain.Professor entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Added;
        }

        public void Update(Domain.Professor entity)
        {
            var item = FindById(entity.Id);
            _context.Entry(item).CurrentValues.SetValues(entity);
        }

        public void Delete(int id)
        {
            var item = FindById(id);
            _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
        }

        public Domain.Professor FindById(int id, params Expression<Func<Domain.Professor, object>>[] includes)
        {
            IQueryable<Domain.Professor> query = _context.Set<Domain.Professor>();
            foreach (var includeProperty in includes)
            {
                query = query.Include(includeProperty);
            }
            return query.FirstOrDefault(a => a.Id == id);
        }

        public IQueryable<Domain.Professor> FilterBy(Expression<Func<Domain.Professor, bool>> expression, params Expression<Func<Domain.Professor, object>>[] includes)
        {

            IQueryable<Domain.Professor> query = _context.Set<Domain.Professor>();
            foreach (var includeProperty in includes)
            {
                query = query.Include(includeProperty);
            }
            return query.Where(expression).AsNoTracking();
        }

    }
}
