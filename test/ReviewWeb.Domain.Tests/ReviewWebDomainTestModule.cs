using ReviewWeb.MongoDB;
using Volo.Abp.Modularity;

namespace ReviewWeb
{
    [DependsOn(
        typeof(ReviewWebMongoDbTestModule)
        )]
    public class ReviewWebDomainTestModule : AbpModule
    {

    }
}