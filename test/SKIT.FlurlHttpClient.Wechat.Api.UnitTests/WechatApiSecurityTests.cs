using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class WechatApiUtilityTests
    {
        [Fact(DisplayName = "信息摘要（SHA-1）")]
        public void Sha1HashTest()
        {
            string rawData = "jsapi_ticket=HoagFKDcsGMVCIY2vOjf9nGrZ3eaM0qXs5ROFN_3k_HrGc0VocemA6wMXkvrL-Ei4IitXxwKF62CJWR8mWXZ3Q&noncestr=e7b435f73835402da44f16640ddc8696&timestamp=1621348162&url=https://mp.weixin.qq.com/debug/cgi-bin/sandbox?t=jsapisign";

            string actualHash = Security.SHA1Utility.Hash(rawData);
            string expectdHash = "b214ea1f8ae019c207f8c6ffb843c8474cbab28c";

            Assert.Equal(expectdHash, actualHash, ignoreCase: true);
        }

        [Fact(DisplayName = "信息摘要（HMAC-SHA-256）")]
        public void HmacSha1HashTest()
        {
            string secret = "zNLgAGgqsEWJOg1nFVaO5r7fAlIQxr1u";
            string rawData = "appid=wx1234567&offer_id=12345678&openid=odkx20ENSNa2w5y3g_qOkOvBNM1g&pf=android&ts=1507530737&zone_id=1&org_loc=/cgi-bin/midas/getbalance&method=POST&secret=zNLgAGgqsEWJOg1nFVaO5r7fAlIQxr1u";

            string actualHash = Security.HMACSHA256Utility.Hash(secret, rawData);
            string expectdHash = "1ad64e8dcb2ec1dc486b7fdf01f4a15159fc623dc3422470e51cf6870734726b";

            Assert.Equal(expectdHash, actualHash, ignoreCase: true);
        }
    }
}
