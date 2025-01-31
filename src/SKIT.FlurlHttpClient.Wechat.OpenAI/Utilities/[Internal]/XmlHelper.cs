using System;
using System.Xml;
using Newtonsoft.Json;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Utilities
{
    using SKIT.FlurlHttpClient.Internal;

    internal static class XmlHelper
    {
        public static string Serialize(object obj, Type type)
        {
            return _XmlSimpleSerializer.Serialize(obj, type);
        }

        public static string Serialize<T>(T obj)
            where T : class
        {
            return Serialize(obj, typeof(T));
        }

        public static object Deserialize(string xml, Type type)
        {
            return _XmlSimpleSerializer.Deserialize(xml, type);
        }

        public static T Deserialize<T>(string xml)
           where T : class
        {
            return (T)Deserialize(xml, typeof(T));
        }

        public static string ConvertFromJson(string json)
        {
            XmlDocument xmlDocument = JsonConvert.DeserializeXmlNode(json, "xml")!;
            string xml = xmlDocument.InnerXml;
            return xml;
        }
    }
}
