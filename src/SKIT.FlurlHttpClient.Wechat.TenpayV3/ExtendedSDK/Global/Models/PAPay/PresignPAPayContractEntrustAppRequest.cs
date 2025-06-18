using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/contracts/app-pre-entrust-sign 接口的请求。</para>
    /// </summary>
    public class PresignPAPayContractEntrustAppRequest : WechatTenpayGlobalRequest
    {
        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public virtual string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 获取或设置商户侧签约协议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_contract_code")]
        [System.Text.Json.Serialization.JsonPropertyName("out_contract_code")]
        public string OutContractCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户账户展示名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_display_name")]
        [System.Text.Json.Serialization.JsonPropertyName("user_display_name")]
        public string UserDisplayName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("success_notify_url")]
        public string NotifyUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户终端 IP。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_client_ip")]
        [System.Text.Json.Serialization.JsonPropertyName("user_client_ip")]
        public string? ClientIp { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置过期时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expired_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("expired_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? ExpireTime { get; set; }

        /// <summary>
        /// 获取或设置签约后跳转地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_url")]
        [System.Text.Json.Serialization.JsonPropertyName("return_url")]
        public string? ReturnUrl { get; set; }
    }
}
