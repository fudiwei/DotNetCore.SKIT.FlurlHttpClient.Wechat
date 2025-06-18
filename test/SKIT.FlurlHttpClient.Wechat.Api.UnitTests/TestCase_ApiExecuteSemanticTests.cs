using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class TestCase_ApiExecuteSemanticTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /semantic/semproxy/search")]
        public async Task TestExecuteSemanticSemproxySearchRestaurant()
        {
            var request = new Models.SemanticSemproxySearchRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken,
                UserId = TestConfigs.WechatOpenId,
                Query = "中关村有没有人均100元左右的火锅店",
                Category = "restaurant",
                City = "北京"
            };
            var response = await TestClients.Instance.ExecuteSemanticSemproxySearchAsync<Models.SemanticSemproxySearchResponse.Types.RestaurantDetail>(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.Query);
            Assert.NotNull(response.Type);
            Assert.NotNull(response.Semantic);
            Assert.NotNull(response.Semantic.Detail);
            Assert.NotNull(response.Semantic.Intent);
        }
    }
}
