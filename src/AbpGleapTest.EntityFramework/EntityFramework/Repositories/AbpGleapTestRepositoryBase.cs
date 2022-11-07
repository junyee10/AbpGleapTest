using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace AbpGleapTest.EntityFramework.Repositories
{
    public abstract class AbpGleapTestRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AbpGleapTestDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AbpGleapTestRepositoryBase(IDbContextProvider<AbpGleapTestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AbpGleapTestRepositoryBase<TEntity> : AbpGleapTestRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AbpGleapTestRepositoryBase(IDbContextProvider<AbpGleapTestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
