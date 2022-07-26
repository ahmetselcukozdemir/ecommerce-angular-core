﻿using eCommerceAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static eCommerceAPI.Application.Repositories.IRepository;

namespace eCommerceAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T: BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T,bool>> method);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
        Task<T> GetByIdAsync(string id);
    }
}
