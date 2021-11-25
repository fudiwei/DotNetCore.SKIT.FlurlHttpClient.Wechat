using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class WechatTenpaySensitivePropertyAttribute : Attribute
    {
        public string Algorithm { get; }

        public WechatTenpaySensitivePropertyAttribute(string algorithm)
        {
            Algorithm = algorithm;
        }
    }
}
