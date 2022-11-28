using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_ApiExecuteMarketingPayGiftActivityTests
    {
        [Fact(DisplayName = "测试用例：调用 API [GET] /marketing/paygiftactivity/activities")]
        public async Task TestExecuteQueryMarketingPayGiftActivities()
        {
            var request = new Models.QueryMarketingPayGiftActivitiesRequest();
            var response = await TestClients.InstanceUseRSA.ExecuteQueryMarketingPayGiftActivitiesAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.ActivityList);

            if (response.ActivityList.Any())
            {
                Assert.NotNull(response.ActivityList.First().ActivityId);
                Assert.NotNull(response.ActivityList.First().ActivityStatus);
                Assert.NotNull(response.ActivityList.First().ActivityBase);
                Assert.NotNull(response.ActivityList.First().AwardSendRule);
            }
        }
    }
}
