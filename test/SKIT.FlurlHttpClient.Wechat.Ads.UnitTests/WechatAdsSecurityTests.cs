using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Ads.UnitTests
{
    public class WechatAdsSecurityTests
    {
        [Fact(DisplayName = "信息摘要（MD5）")]
        public void Md5HashTest()
        {
            string rawData = "spidbff89d5138160943040012345678901234567890uFolxxiZbrZ/PRbyen5uK5D1kgIB2yHyDsfDGxxgeG";

            string actualHash = Security.MD5Utility.Hash(rawData);
            string expectedHash = "32c03e8fcdb08e653e42805e302f70ed";

            Assert.Equal(expectedHash, actualHash, ignoreCase: true);
        }
    }
}
