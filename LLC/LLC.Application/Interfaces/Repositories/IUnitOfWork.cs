using LLC.Domain.Contracts;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace LLC.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryAsync<T> Repository<T>() where T : AuditableEntity;
        IRepositoryAsync<T> Repository2<T>() where T : LLC.Application.Models.Identity.LLCUser;
        Task<int> Commit(CancellationToken cancellationToken);

        Task<int> ComitAndRemoveCache(CancellationToken cancellationToken, string cacheKey);

        Task Rollback();
    }
}