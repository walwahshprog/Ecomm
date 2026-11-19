using System;
using System.Linq.Expressions;

namespace Ecom.Core.Interfaces;

public interface IGenericRepo<T>where T : class
{
    
    Task<T> GetByIdAsync(Guid id) ;
    Task<T?> GetByIdAsync(Guid id, params Expression<Func<T, object>>[] includes) ;

    Task<IReadOnlyList<T>> GetAllAsync(params Expression<Func<T, object>>[] includes) ;
    Task<IReadOnlyList<T>> GetAllAsync(T entity) ;
    Task<T> AddAsync(T entity) ;
    Task<T> UpdateAsync(T entity) ;
    Task<bool> DeleteAsync(Guid id) ;



}
