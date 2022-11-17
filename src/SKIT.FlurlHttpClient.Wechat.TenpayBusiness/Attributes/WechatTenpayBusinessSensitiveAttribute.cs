using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class WechatTenpayBusinessSensitiveAttribute : Attribute
    {
        public WechatTenpayBusinessSensitiveAttribute()
        {
        }
    }
}
