using System.Xml;
using Newtonsoft.Json;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    internal static class XmlUtility
    {
        public static string ConvertFromJson(string json)
        {
            XmlDocument xmlDocument = JsonConvert.DeserializeXmlNode(json);
            return xmlDocument.InnerXml;
        }

        public static string ConvertToJson(string xml)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);
            return JsonConvert.SerializeXmlNode(xmlDocument);
        }
    }
}
