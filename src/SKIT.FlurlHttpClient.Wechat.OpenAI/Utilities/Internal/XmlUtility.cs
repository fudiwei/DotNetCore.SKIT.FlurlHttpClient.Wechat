using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Utilities
{
    internal static class XmlUtility
    {
        // REF: https://docs.microsoft.com/zh-cn/dotnet/api/system.xml.serialization.xmlserializer#dynamically-generated-assemblies
        private static Hashtable _serializers = new Hashtable();

        public static string Serialize(Type type, object obj)
        {
            string xml;

            var settings = new XmlWriterSettings();
            settings.Encoding = Encoding.UTF8;
            settings.Indent = false;
            settings.OmitXmlDeclaration = true;
            settings.WriteEndDocumentOnClose = false;
            settings.NamespaceHandling = NamespaceHandling.OmitDuplicates;

            string skey = type.AssemblyQualifiedName;
            XmlSerializer? xmlSerializer = (XmlSerializer)_serializers[skey];
            if (xmlSerializer == null)
            {
                xmlSerializer = new XmlSerializer(type, new XmlRootAttribute("xml"));
                _serializers[skey] = xmlSerializer;
            }

            using var stream = new MemoryStream();
            using var writer = XmlWriter.Create(stream, settings);
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
