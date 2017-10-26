using ListaDeFilmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListaDeFilmes.Domain.Contracts.Repositories
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        T Add(T entidade);
        T Edit(T entidade);
        void Del(T entidade);

        IEnumerable<T> Get();
        Task<IEnumerable<T>> GetAsync();

        T Get(object id);
        Task<T> GetAsync(object id);
    }
}
