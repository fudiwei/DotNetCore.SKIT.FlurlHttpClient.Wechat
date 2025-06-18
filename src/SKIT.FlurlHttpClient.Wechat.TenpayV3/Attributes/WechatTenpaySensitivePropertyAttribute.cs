using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    public sealed class WechatTenpaySensitivePropertyAttribute : Attribute
    {
        public string Scheme { get; }

        public string Algorithm { get; }

        public WechatTenpaySensitivePropertyAttribute(string scheme, string algorithm)
        {
            Scheme = scheme;
            Algorithm = algorithm;
        }
    }
}
