using System;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.UnitTests
{
    public class TestCase_ToolsSM3UtilityTests
    {
        [Fact(DisplayName = "测试用例：计算 SM3 哈希值")]
        public void TestSM3Hash()
        {
            byte[] msgBytes = Convert.FromBase64String("QXdlc29tZSBTS0lULkZsdXJsSHR0cENsaWVudC5XZWNoYXQuVGVucGF5QnVzaW5lc3Mh");
            string expectedHashText = "A7A58FCEDDDEE4BD2E05887E5F4D8B7D662357BE474F3821CA858EE1CFFB4B83";
            string actualHashText = BitConverter.ToString(Utilities.SM3Utility.Hash(msgBytes)).Replace("-", "");

            Assert.Equal(actualHashText, expectedHashText, ignoreCase: true);
        }
    }
}
