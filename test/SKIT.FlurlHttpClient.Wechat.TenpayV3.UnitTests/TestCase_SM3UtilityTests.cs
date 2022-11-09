using System;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_SM3UtilityTests
    {
        [Fact(DisplayName = "测试用例：计算 SM3 哈希值")]
        public void TestSM3Hash()
        {
            byte[] msgBytes = Convert.FromBase64String("QXdlc29tZSBTS0lULkZsdXJsSHR0cENsaWVudC5XZWNoYXQuVGVucGF5VjMh");
            string expectedHashText = "3F5EC5A79871755905E34013FD86D906B334281D2CA5B9FF612A136C7C377815";
            string actualHashText = BitConverter.ToString(Utilities.SM3Utility.Hash(msgBytes)).Replace("-", "");

            Assert.Equal(actualHashText, expectedHashText, ignoreCase: true);
        }
    }
}
