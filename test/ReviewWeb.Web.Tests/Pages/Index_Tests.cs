using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ReviewWeb.Pages
{
    [Collection(ReviewWebTestConsts.CollectionDefinitionName)]
    public class Index_Tests : ReviewWebWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
