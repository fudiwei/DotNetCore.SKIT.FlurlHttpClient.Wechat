using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Utilities
{
    internal static class XmlUtility
    {
        public static string Serialize(Type type, object obj)
        {
            string xml;

            var settings = new XmlWriterSettings();
            settings.Encoding = Encoding.UTF8;
            settings.Indent = false;
            settings.OmitXmlDeclaration = true;
            settings.WriteEndDocumentOnClose = false;
            settings.NamespaceHandling = NamespaceHandling.OmitDuplicates;

            using var stream = new MemoryStream();
            using var writer = XmlWriter.Create(stream, settings);

            XmlSerializer xmlSerializer = new XmlSerializer(type, new XmlRootAttribute("xml"));
            XmlSerializerNamespaces xmlNamespace = new XmlSerializerNamespaces();
            xmlNamespace.Add(string.Empty, string.Empty);
            xmlSerializer.Serialize(writer, obj, xmlNamespace);
            writer.Flush();
            xml = Encoding.UTF8.GetString(stream.ToArray());
            xml = Regex.Replace(xml, "\\s*<\\w+ (xsi|d2p1):nil=\"true\"[^>]*/>", string.Empty, RegexOptions.IgnoreCase);
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
