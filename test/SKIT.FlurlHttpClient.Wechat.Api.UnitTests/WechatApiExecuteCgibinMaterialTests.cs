using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class WechatApiExecuteCgibinMaterialTests
    {
        [Fact(DisplayName = "[GET] /cgi-bin/material/get_materialcount")]
        public async Task CgibinMaterialGetMaterialCountTest()
        {
            var request = new Models.CgibinMaterialGetMaterialCountRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinMaterialGetMaterialCountAsync(request);

            Assert.True(response.IsSuccessful());
        }

        [Fact(DisplayName = "[POST] /cgi-bin/material/batchget_material")]
        public async Task CgibinMaterialBatchGetMaterialTest()
        {
            var request = new Models.CgibinMaterialBatchGetMaterialRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken,
                Type = "news"
            };
            var response = await TestClients.Instance.ExecuteCgibinMaterialBatchGetMaterialAsync(request);

            Assert.True(response.IsSuccessful());

            if (response.Total > 0)
            {
                Assert.Equal(response.Count, response.MaterialList.Length);
                Assert.NotEmpty(response.MaterialList);
                Assert.NotEmpty(response.MaterialList.First().MediaId);
            }
        }
    }
}
