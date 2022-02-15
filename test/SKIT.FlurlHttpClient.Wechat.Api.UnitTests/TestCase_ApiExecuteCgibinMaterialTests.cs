using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class TestCase_ApiExecuteCgibinMaterialTests
    {
        [Fact(DisplayName = "测试用例：调用 API [GET] /cgi-bin/material/get_materialcount")]
        public async Task TestExecuteCgibinMaterialGetMaterialCount()
        {
            var request = new Models.CgibinMaterialGetMaterialCountRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinMaterialGetMaterialCountAsync(request);

            Assert.True(response.IsSuccessful());
        }

        [Fact(DisplayName = "测试用例：调用 API [POST] /cgi-bin/material/batchget_material")]
        public async Task TestExecuteCgibinMaterialBatchGetMaterial()
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
