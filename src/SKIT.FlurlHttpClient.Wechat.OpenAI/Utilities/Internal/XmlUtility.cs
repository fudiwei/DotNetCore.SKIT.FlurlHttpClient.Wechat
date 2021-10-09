using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Utilities
{
    internal static class XmlUtility
    {
        public static string Serialize(Type type, object obj)
        {
            string xml;

            using var stream = new MemoryStream();
            using var writer = new System.Xml.XmlTextWriter(stream, Encoding.UTF8);
            writer.Formatting = System.Xml.Formatting.None;

            XmlSerializer xmlSerializer = new XmlSerializer(type, new XmlRootAttribute("xml"));
            XmlSerializerNamespaces xmlNamespace = new XmlSerializerNamespaces();
            xmlNamespace.Add(string.Empty, string.Empty);
            xmlSerializer.Serialize(writer, obj, xmlNamespace);
            writer.Flush();
            xml = Encoding.UTF8.GetString(stream.ToArray());
            xml = Regex.Replace(xml, "\\s+<\\w+ (xsi|d2p1):nil=\"true\"[^>]*/>", string.Empty, RegexOptions.IgnoreCase);
            xml = Regex.Replace(xml, "<\\?xml[^>]*\\?>", string.Empty, RegexOptions.IgnoreCase);

            return xml;
        }

        public static string Serialize<T>(T obj)
            where T : class
        {
            return Serialize(typeof(T), obj);
        }
    }
}
