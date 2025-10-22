﻿using Main.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Main.Domain.InterfacesRepository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, string? includeProperties = null, CancellationToken cancellationToken = default);
        Task<T> GetFirstAsync(Expression<Func<T, bool>> filter = null, string? includeProperties = null, CancellationToken cancellationToken = default);
        Task<T> CreateAsync(T item, CancellationToken cancellationToken = default);
        Task<T> UpdateAsync(T item, CancellationToken cancellationToken = default);
        Task DeleteAsync(Expression<Func<T, bool>> filter, CancellationToken cancellationToken = default);
        Task<bool> IsExistsAsync(Expression<Func<T, bool>> filter = null, CancellationToken cancellationToken = default);
        //Task<(IEnumerable<T> Items, int TotalCount)> GetPagedAsync(
        //   int pageNumber,
        //   int pageSize,
        //   Expression<Func<T, bool>> filter = null,
        //   string includeProperties = null,
        //   CancellationToken cancellationToken = default);
    }
}
