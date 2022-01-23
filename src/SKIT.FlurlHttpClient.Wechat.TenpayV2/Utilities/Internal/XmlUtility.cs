using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    internal static class XmlUtility
    {
        public static string ConvertFromJson(string json)
        {
            XmlDocument xmlDocument = JsonConvert.DeserializeXmlNode(json, "xml");
            string xml = xmlDocument.InnerXml;
            return xml;
        }

        public static string ConvertToJson(string xml)
        {
            XElement xElement = XElement.Parse(xml);
            XCData[] xCDatas = xElement.DescendantNodes().OfType<XCData>().ToArray();
            foreach (XCData xCData in xCDatas)
            {
                xCData.Parent.Add(xCData.Value);
                xCData.Remove();
            }

            JObject jObject = JsonConvert.DeserializeObject<JObject>(JsonConvert.SerializeXNode(xElement));
            string json = (jObject.First as JProperty)?.Value?.ToString(Newtonsoft.Json.Formatting.None) ?? "{}";
            return json;
        }
    }
}
