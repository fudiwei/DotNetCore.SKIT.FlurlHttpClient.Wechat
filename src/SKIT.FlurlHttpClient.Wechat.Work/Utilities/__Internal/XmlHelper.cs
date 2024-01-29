using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.Utilities
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
    }
}
