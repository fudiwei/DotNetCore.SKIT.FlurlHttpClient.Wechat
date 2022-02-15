using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 表示微信支付 API 请求的基类。
    /// </summary>
    public abstract class WechatTenpayRequest : ICommonRequest
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.Timeout"/> 参数，这在需要指定特定耗时请求（比如上传或下载文件）的超时时间时很有用。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual int? Timeout { get; set; }

        /// <summary>
        /// <i>（本参数已废弃，请使用 <see cref="WechatpayCertificateSerialNumber"/> 参数）</i>
        /// </summary>
        [Obsolete("本参数已废弃，请使用 `WechatpayCertificateSerialNumber` 参数")]
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? WechatpayCertSerialNumber { get { return WechatpayCertificateSerialNumber; } set { WechatpayCertificateSerialNumber = value; } }

        /// <summary>
        /// 获取或设置微信请求使用的微信支付平台证书序列号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? WechatpayCertificateSerialNumber { get; set; }
    }
}
