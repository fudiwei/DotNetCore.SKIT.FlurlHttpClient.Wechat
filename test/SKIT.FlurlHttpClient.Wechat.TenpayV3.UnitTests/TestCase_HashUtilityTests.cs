using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_HashUtilityTests
    {
        [Fact(DisplayName = "测试用例：SHA-256 信息摘要")]
        public void TestSHA256Hash()
        {
            string rawData = "SHA256HashTest";

            string actualHash = Utilities.SHA256Utility.Hash(rawData);
            string expectedHash = "8446f1ce5ca8b4a87c0d0cc15be4ba173b2ff78dc33c5f6731d877dcd2d8f401";

            Assert.Equal(expectedHash, actualHash, ignoreCase: true);
        }
    }
}
