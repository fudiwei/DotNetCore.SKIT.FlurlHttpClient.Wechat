using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class TestCase_ApiExecuteCgibinUserTests
    {
        [Fact(DisplayName = "测试用例：调用 API [GET] /cgi-bin/user/info")]
        public async Task TestExecuteCgibinUserInfo()
        {
            var request = new Models.CgibinUserInfoRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken,
                OpenId = TestConfigs.WechatOpenId
            };
            var response = await TestClients.Instance.ExecuteCgibinUserInfoAsync(request);

            Assert.NotEmpty(response.OpenId);
            Assert.True(response.IsSubscribed);
        }

        [Fact(DisplayName = "测试用例：调用 API [POST] /cgi-bin/user/info/batchget")]
        public async Task TestExecuteCgibinUserInfoBatchGet()
        {
            var request = new Models.CgibinUserInfoBatchGetRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken,
                UserList = new Models.CgibinUserInfoBatchGetRequest.Types.User[]
                {
                    new Models.CgibinUserInfoBatchGetRequest.Types.User() { OpenId = TestConfigs.WechatOpenId }
                }
            };
            var response = await TestClients.Instance.ExecuteCgibinUserInfoBatchGetAsync(request);

            Assert.NotEmpty(response.UserList);
            Assert.NotEmpty(response.UserList.First().OpenId);
            Assert.True(response.UserList.First().IsSubscribed);
        }

        [Fact(DisplayName = "测试用例：调用 API [POST] /cgi-bin/user/info/updateremark")]
        public async Task TestExecuteCgibinUserInfoUpdateRemark()
        {
            var request = new Models.CgibinUserInfoUpdateRemarkRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken,
                OpenId = TestConfigs.WechatOpenId,
                Remark = "FAKE_REMARK"
            };
            var response = await TestClients.Instance.ExecuteCgibinUserInfoUpdateRemarkAsync(request);

            Assert.Equal(0, response.ErrorCode);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /cgi-bin/user/get")]
        public async Task TestExecuteCgibinUserGet()
        {
            var request = new Models.CgibinUserGetRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinUserGetAsync(request);

            Assert.NotEmpty(response.Data.OpenIdList);
            Assert.True(response.Total > 0);
            Assert.True(response.Count > 0);
        }
    }
}
