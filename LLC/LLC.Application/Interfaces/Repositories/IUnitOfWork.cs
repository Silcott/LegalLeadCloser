using LLC.Domain.Contracts;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace LLC.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryAsync<T> Repository<T>() where T : AuditableEntity;
        //Repo2 is for retreiving the no. of users from the user database to get eh dateCreated for graphs
        IRepositoryAsync<T> Repository2<T>() where T : LLC.Application.Models.Identity.LLCUser;
        Task<int> Commit(CancellationToken cancellationToken);

        Task<int> ComitAndRemoveCache(CancellationToken cancellationToken, string cacheKey);

        Task Rollback();
    }
}