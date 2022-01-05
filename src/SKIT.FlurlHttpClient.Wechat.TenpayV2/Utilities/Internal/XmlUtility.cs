using System;
using System.Collections;
using System.IO;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
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
