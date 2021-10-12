using Volo.Abp.Modularity;

namespace ReviewWeb
{
    [DependsOn(
        typeof(ReviewWebApplicationModule),
        typeof(ReviewWebDomainTestModule)
        )]
    public class ReviewWebApplicationTestModule : AbpModule
    {

    }
}