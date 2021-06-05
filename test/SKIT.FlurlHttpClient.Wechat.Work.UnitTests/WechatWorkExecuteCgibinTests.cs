using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests
{
    public class WechatWorkExecuteCgibinTests
    {
        [Fact(DisplayName = "[GET] /cgi-bin/gettoken")]
        public async Task CgibinTokenTest()
        {
            var request = new Models.CgibinGetTokenRequest();
            var response = await TestClients.Instance.ExecuteCgibinGetTokenAsync(request);

            Assert.NotNull(response.AccessToken);
        }
    }
}
