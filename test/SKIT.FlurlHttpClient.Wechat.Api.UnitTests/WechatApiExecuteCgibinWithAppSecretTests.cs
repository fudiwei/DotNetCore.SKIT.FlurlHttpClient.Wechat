using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class WechatApiExecuteCgibinWithAppSecretTests
    {
        [Fact(DisplayName = "[GET] /sns/cgi-bin/token")]
        public async Task CgibinTokenTest()
        {
            var request = new Models.CgibinTokenRequest();
            var response = await TestClients.Instance.ExecuteCgibinTokenAsync(request);

            Assert.NotNull(response.AccessToken);
        }
    }
}
