using ReviewWeb.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ReviewWeb.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ReviewWebMongoDbModule),
        typeof(ReviewWebApplicationContractsModule)
    )]
    public class ReviewWebDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options =>
            {
                options.IsJobExecutionEnabled = false;
            });
        }
    }
}
