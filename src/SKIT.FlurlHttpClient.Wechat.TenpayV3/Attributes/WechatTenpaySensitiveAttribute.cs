using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class WechatTenpaySensitiveAttribute : Attribute
    {
        public WechatTenpaySensitiveAttribute()
        {
        }
    }
}
