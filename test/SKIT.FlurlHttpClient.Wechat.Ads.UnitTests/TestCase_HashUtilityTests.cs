﻿using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Ads.UnitTests
{
    public class TestCase_HashUtilityTests
    {
        [Fact(DisplayName = "测试用例：MD5 信息摘要")]
        public void TestMD5Hash()
        {
            string rawData = "spidbff89d5138160943040012345678901234567890uFolxxiZbrZ/PRbyen5uK5D1kgIB2yHyDsfDGxxgeG";

            string actualHash = Utilities.MD5Utility.Hash(rawData);
            string expectedHash = "32c03e8fcdb08e653e42805e302f70ed";

            Assert.Equal(expectedHash, actualHash, ignoreCase: true);
        }
    }
}
