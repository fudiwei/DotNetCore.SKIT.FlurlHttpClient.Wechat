using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class WechatTenpayBusinessSensitivePropertyAttribute : Attribute
    {
        public WechatTenpayBusinessSensitivePropertyAttribute()
        {
        }
    }
}
