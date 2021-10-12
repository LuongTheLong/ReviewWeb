using ReviewWeb.MongoDB;
using Xunit;

namespace ReviewWeb
{
    [CollectionDefinition(ReviewWebTestConsts.CollectionDefinitionName)]
    public class ReviewWebDomainCollection : ReviewWebMongoDbCollectionFixtureBase
    {

    }
}
