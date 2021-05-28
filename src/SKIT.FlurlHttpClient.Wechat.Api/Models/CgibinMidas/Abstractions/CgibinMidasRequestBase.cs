using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    public abstract class CgibinMidasRequestBase : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置米大师分配的 OfferId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offer_id")]
        [System.Text.Json.Serialization.JsonPropertyName("offer_id")]
        public string MidasOfferId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置米大师分区。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zone_id")]
        [System.Text.Json.Serialization.JsonPropertyName("zone_id")]
        public string MidasZoneId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置米大师环境。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string MidasEnv { get; set; } = string.Empty;

        /// <summary>
        /// <para>获取或设置平台标识。</para>
        /// <para>默认值：android</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pf")]
        [System.Text.Json.Serialization.JsonPropertyName("pf")]
        public string Platform { get; set; } = "android";

        /// <summary>
        /// 获取或设置用户 IP。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_ip")]
        [System.Text.Json.Serialization.JsonPropertyName("user_ip")]
        public string? UserIp { get; set; }

        /// <summary>
        /// 获取或设置请求时间戳。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ts")]
        [System.Text.Json.Serialization.JsonPropertyName("ts")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// 获取或设置请求签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sig")]
        [System.Text.Json.Serialization.JsonPropertyName("sig")]
        public string? Signature { get; set; }
    }
}
