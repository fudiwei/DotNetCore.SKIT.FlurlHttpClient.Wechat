using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class WechatTenpayExecuteMarketingPayGiftActivityTests
    {
        [Fact(DisplayName = "[GET] /marketing/paygiftactivity/activities")]
        public async Task QueryMarketingPayGiftActivitiesTest()
        {
            var request = new Models.QueryMarketingPayGiftActivitiesRequest();
            var response = await TestClients.Instance.ExecuteQueryMarketingPayGiftActivitiesAsync(request);

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
