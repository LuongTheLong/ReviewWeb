using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ReviewWeb.Data
{
    /* This is used if database provider does't define
     * IReviewWebDbSchemaMigrator implementation.
     */
    public class NullReviewWebDbSchemaMigrator : IReviewWebDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}