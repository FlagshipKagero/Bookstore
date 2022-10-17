using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Bookstore.EntityFramework.Repositories
{
    public abstract class BookstoreRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<BookstoreDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected BookstoreRepositoryBase(IDbContextProvider<BookstoreDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class BookstoreRepositoryBase<TEntity> : BookstoreRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected BookstoreRepositoryBase(IDbContextProvider<BookstoreDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
