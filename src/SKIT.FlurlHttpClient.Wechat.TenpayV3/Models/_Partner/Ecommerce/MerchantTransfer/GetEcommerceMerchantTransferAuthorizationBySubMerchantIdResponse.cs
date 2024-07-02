using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/mch-transfer/authorizations/{sub_mchid} 接口的响应。</para>
    /// </summary>
    public class GetEcommerceMerchantTransferAuthorizationBySubMerchantIdResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_state")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_state")]
        public string AuthorizationState { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorize_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("authorize_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? AuthorizeTime { get; set; }
    }
}
