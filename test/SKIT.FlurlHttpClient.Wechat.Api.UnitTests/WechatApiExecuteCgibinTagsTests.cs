using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class WechatApiExecuteCgibinTagsTests
    {
        [Fact(DisplayName = "[POST] /cgi-bin/tags/create")]
        public async Task CgibinTagsCreateTest()
        {
            var request = new Models.CgibinTagsCreateRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken,
                Tag = new Models.CgibinTagsCreateRequest.Types.Tag() 
                { 
                    Name = "FAKE_TAGNAME" 
                }
            };
            var response = await TestClients.Instance.ExecuteCgibinTagsCreateAsync(request);

            Assert.True(response.Tag.Id > 0);
            Assert.Equal(request.Tag.Name, response.Tag.Name);
        }

        [Fact(DisplayName = "[POST] /cgi-bin/tags/get")]
        public async Task CgibinTagsGetTest()
        {
            var request = new Models.CgibinTagsGetRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken
            };
            var response = await TestClients.Instance.ExecuteCgibinTagsGetAsync(request);

            Assert.NotEmpty(response.Tags);
            Assert.True(response.Tags.First().Id > 0);
            Assert.NotNull(response.Tags.First().Name);
        }
    }
}
