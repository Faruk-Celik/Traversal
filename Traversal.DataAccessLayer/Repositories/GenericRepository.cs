﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Traversal.DataAccessLayer.Abstact;
using Traversal.DataAccessLayer.Context;

namespace Traversal.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly TraversalContext _context;

        public GenericRepository ( TraversalContext context )
        {
            _context = context;
        }

        public void Delete ( int id )
        {
            var values = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(values);
            _context.SaveChanges();
        }

        public List<T> GetListAll ()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById ( int id )
        {
            return _context.Set<T>().Find(id);

        }

        public void Insert ( T entity )
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update ( T entity )
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        public List<T> GetListByFilter ( Expression<Func<T, bool>> filter )
        {
           return _context.Set<T>().Where(filter).ToList();
        }
    }
}
