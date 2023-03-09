using Newtonsoft.Json.Linq;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests
{
    public class TestCase_ToolsXmlUtilityTests
    {
        [Fact(DisplayName = "测试用例：XML2JSON")]
        public void TestXmlConvertToJson()
        {
            string xml = "<xml><return_code><![CDATA[SUCCESS]]></return_code><return_msg><![CDATA[OK]]></return_msg></xml>";
            string json = Utilities.XmlUtility.ConvertToJson(xml); ;

            JObject jObject = JObject.Parse(json)!;
            Assert.Equal("SUCCESS", jObject["return_code"]!.ToString());
            Assert.Equal("OK", jObject["return_msg"]!.ToString());
        }
    }
}
