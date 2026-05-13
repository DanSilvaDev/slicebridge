using System;
using System.Threading.Tasks;

namespace SliceBridge.Core.Common.Repositories.Interfaces;

public interface IRepository
{
    public Task<T> SaveAsync<T>(T entity) where T : class;
    public Task DeleteAsync<T>(T entity) where T : class;
}