using Newtonsoft.Json.Linq;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests.TestCases.Utils
{
    public class TestCase_XmlHelperTests
    {
        [Fact(DisplayName = "测试用例：工具类 `XmlHelper.ConvertToJson`")]
        public void TestXmlConvertToJson()
        {
            string xml = "<xml><return_code><![CDATA[SUCCESS]]></return_code><return_msg><![CDATA[OK]]></return_msg></xml>";
            string json = Utilities.XmlHelper.ConvertToJson(xml); ;

            JObject jObject = JObject.Parse(json)!;
            Assert.Equal("SUCCESS", jObject["return_code"]!.ToString());
            Assert.Equal("OK", jObject["return_msg"]!.ToString());
        }
    }
}
