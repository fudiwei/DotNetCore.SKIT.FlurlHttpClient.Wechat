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
        private static readonly Hashtable _xmlSerializers = new Hashtable();
        private static readonly XmlRootAttribute _xmlRoot = new XmlRootAttribute("xml");

        private static XmlSerializer GetTypedSerializer(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));

            string skey = type.AssemblyQualifiedName ?? type.GetHashCode().ToString();
            XmlSerializer? xmlSerializer = (XmlSerializer?)_xmlSerializers[skey];
            if (xmlSerializer == null)
            {
                xmlSerializer = new XmlSerializer(type, _xmlRoot);
                _xmlSerializers[skey] = xmlSerializer;
            }

            return xmlSerializer;
        }

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
            XmlSerializer serializer = GetTypedSerializer(type);
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add(string.Empty, string.Empty);
            serializer.Serialize(writer, obj, ns);
            writer.Flush();
            xml = Encoding.UTF8.GetString(stream.ToArray());
            xml = Regex.Replace(xml, "\\s*<\\w+ ([a-zA-Z0-9]+):nil=\"true\"[^>]*/>", string.Empty, RegexOptions.IgnoreCase);
            xml = Regex.Replace(xml, "<\\?xml[^>]*\\?>", string.Empty, RegexOptions.IgnoreCase);

            return xml;
        }

        public static string Serialize<T>(T obj)
            where T : class
        {
            return Serialize(typeof(T), obj);
        }

        public static string Serialize(object obj)
        {
            return Serialize(obj.GetType(), obj);
        }

        public static object Deserialize(Type type, string xml)
        {
            using var reader = new StringReader(xml);
            XmlSerializer serializer = GetTypedSerializer(type);
            return serializer.Deserialize(reader)!;
        }

        public static T Deserialize<T>(string xml)
           where T : class
        {
            return (T)Deserialize(typeof(T), xml);
        }
    }
}
