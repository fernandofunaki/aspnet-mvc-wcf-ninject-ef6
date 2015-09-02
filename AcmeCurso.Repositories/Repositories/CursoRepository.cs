﻿using AcmeCurso.Domain;
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
    public class CursoRepository : ICursoRepository
    {
        private DbContext _context;
        public CursoRepository(IUnitOfWork uow)
        {
            this._context = uow.Context as DbContext;
        }

        public void Add(Curso entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Added;
        }

        public void Update(Curso entity)
        {
            var item = FindById(entity.Id);
            _context.Entry(item).CurrentValues.SetValues(entity);
        }

        public void Delete(int id)
        {
            var item = FindById(id);
            _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
        }

        public Domain.Curso FindById(int id, params Expression<Func<Curso, object>>[] includes)
        {
            IQueryable<Domain.Curso> query = _context.Set<Domain.Curso>();
            foreach (var includeProperty in includes)
            {
                query = query.Include(includeProperty);
            }
            return query.FirstOrDefault(a => a.Id == id);
        }

        public IQueryable<Domain.Curso> FilterBy(Expression<Func<Curso, bool>> expression, params Expression<Func<Curso, object>>[] includes)
        {
            IQueryable<Domain.Curso> query = _context.Set<Domain.Curso>();
            foreach (var includeProperty in includes)
            {
                query = query.Include(includeProperty);
            }
            return query.Where(expression).AsNoTracking();
        }
    }
}
