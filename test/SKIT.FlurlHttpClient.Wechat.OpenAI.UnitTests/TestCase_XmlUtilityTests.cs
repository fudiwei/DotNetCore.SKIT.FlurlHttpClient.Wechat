using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
{
    public class TestCase_XmlUtilityTests
    {
        [Fact(DisplayName = "测试用例：XML 序列化派生类")]
        public void TestXmlSerializeSubClass()
        {
            Assert.Null(Record.Exception(() =>
            {
                object obj = new Models.SignRequest() { UserId = "TEST" };
                Utilities.XmlUtility.Serialize(obj);
            }));
        }
    }
}
